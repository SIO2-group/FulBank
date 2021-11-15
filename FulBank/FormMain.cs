using Fulbank.pages;
using Fulbank.classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using FulBank.classes;

namespace FulBank
{

    public partial class FormMain : System.Windows.Forms.Form
    {
        private string _userId;
        public static string dsnConnexion = "server=localhost;database=fulbank;uid=root;password='';SSL MODE='None'"; //préparation pour la connection à la bdd
        public static MySqlConnection dbConnexion = new MySqlConnection(dsnConnexion);
        public static List<Form> ListFormMenu = new List<Form>();
        public static Form Connexion;
        public static User user;
        public static Terminal thisTerminal;
        

        public MySqlConnection getConnexion()
        {
            return dbConnexion;
        }


        public FormMain(string userId, Form FormCo)
        {
            InitializeComponent();
            _userId = userId;
            Connexion = FormCo;
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            user = UserDataLoad();
            thisTerminal = TerminalLoad();
            ListFormMenu.Add(new FormAccount() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            panelMain.Controls.Add(ListFormMenu[0]);
            ListFormMenu.Add(new FormOperation() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            panelMain.Controls.Add(ListFormMenu[1]);
            ListFormMenu.Add(new FormTransfer() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            panelMain.Controls.Add(ListFormMenu[2]);
            ListFormMenu.Add(new FormOperationHistory() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            panelMain.Controls.Add(ListFormMenu[3]);
            ListFormMenu.Add(new FormTransferHistory() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            panelMain.Controls.Add(ListFormMenu[4]);
            ListFormMenu[4].Show();
            ListFormMenu[3].Show();
            ListFormMenu[2].Show();
            ListFormMenu[1].Show();
            ListFormMenu[0].Show();
            ListFormMenu[0].BringToFront();

        }

        private User UserDataLoad()
        {
            dbConnexion.Open();
            string commandTextGetUser = "SELECT P_ID, P_NAME, P_FIRSTNAME, U_PHONE, U_LANDLINE, U_MAIL, U_ADRESS FROM person INNER JOIN user ON person.P_ID = user.U_ID WHERE P_ID = '" + _userId + "' ";
            MySqlCommand cmdGetUser = new MySqlCommand(commandTextGetUser, dbConnexion);
            MySqlDataReader userInfo = cmdGetUser.ExecuteReader();
            userInfo.Read();
            User aUser = new User(int.Parse(userInfo["P_ID"].ToString()), userInfo["P_NAME"].ToString(), userInfo["P_FIRSTNAME"].ToString(), userInfo["U_MAIL"].ToString(), userInfo["U_PHONE"].ToString(), userInfo["U_LANDLINE"].ToString(), userInfo["U_ADRESS"].ToString());
            dbConnexion.Close();
            dbConnexion.Open();
            string commandTextTestUser = "SELECT A_ID, A_ID_ACCOUNTTYPE, A_BALANCE, A_OVERDRAFT_LIMIT FROM account WHERE A_ID_USER = '" + _userId + "' ";
            MySqlCommand cmdGetUserAccounts = new MySqlCommand(commandTextTestUser, dbConnexion);
            MySqlDataReader userAccounts = cmdGetUserAccounts.ExecuteReader();


            while (userAccounts.Read())
            {
                aUser.Add_Account(int.Parse(userAccounts["A_ID"].ToString()), int.Parse(userAccounts["A_ID_ACCOUNTTYPE"].ToString()), double.Parse(userAccounts["A_BALANCE"].ToString()), int.Parse(userAccounts["A_OVERDRAFT_LIMIT"].ToString()));
            }

            dbConnexion.Close();

            dbConnexion.Open();
            string commandTextSelectBeneficiary = "SELECT * FROM beneficiary WHERE B_USER_ID = " + _userId + "";
            MySqlCommand cmdSelectBeneficiary = new MySqlCommand(commandTextSelectBeneficiary, dbConnexion);
            MySqlDataReader userBeneficiaries = cmdSelectBeneficiary.ExecuteReader();


            while(userBeneficiaries.Read())
            {
                aUser.Add_Beneficiary(int.Parse(userBeneficiaries["B_ACCOUNT_ID"].ToString()), userBeneficiaries["B_NAME"].ToString(), int.Parse(_userId));
            }

            dbConnexion.Close();

            #region add transfers
            dbConnexion.Open();
            string commandTextSelectTransfer = @"SELECT T_ID_ACCOUNT_FROM, T_ID_ACCOUNT_TO, T_AMOUNT, DATE_FORMAT(T_DATE,'%d-%m-%Y %H:%i:%s') as T_DATE
                                            FROM transaction
                                            WHERE T_ID_ACCOUNT_FROM IN(SELECT A_ID
                                                                        FROM account
                                                                        WHERE A_ID_USER = '" + aUser.Get_Id() + "')";
            MySqlCommand cmdSelectTransfer = new MySqlCommand(commandTextSelectTransfer, FormMain.dbConnexion);
            MySqlDataReader transfers = cmdSelectTransfer.ExecuteReader();
            while (transfers.Read())
            {
                Account AccountFrom = new Account();
                Account AccountTo = new Account();
                Beneficiary BeneficiaryTo = new Beneficiary();
                foreach (Account account in aUser.GetAccounts())
                {
                    if (account.Get_Id() == int.Parse(transfers["T_ID_ACCOUNT_FROM"].ToString()))
                    {
                        AccountFrom = account;
                    }
                }
                foreach (Account account in aUser.GetAccounts())
                {
                    if (account.Get_Id() == int.Parse(transfers["T_ID_ACCOUNT_TO"].ToString()))
                    {
                        AccountTo = account;
                        DateTime dt = DateTime.Parse(transfers["T_DATE"].ToString());
                        aUser.add_Transfer(double.Parse(transfers["T_AMOUNT"].ToString()), dt, AccountFrom, AccountTo);
                    }
                }
                foreach (Beneficiary beneficiary in aUser.GetBeneficiary())
                {
                    if (beneficiary.getBeneficiaryId() == int.Parse(transfers["T_ID_ACCOUNT_TO"].ToString()))
                    {
                        BeneficiaryTo = beneficiary;
                        DateTime dt = DateTime.Parse(transfers["T_DATE"].ToString());
                        aUser.add_TransferToBeneficiary(double.Parse(transfers["T_AMOUNT"].ToString()), dt, AccountFrom, AccountTo, BeneficiaryTo);
                    }
                }
            }
            dbConnexion.Close();
            return aUser;
            #endregion
        }
           
            
        

        private Terminal TerminalLoad()
        {
            IniFile MyIni = new IniFile("Fulbank.ini");
            Terminal thisTerminal = new Terminal(MyIni.Read("City"), MyIni.Read("Building"), MyIni.Read("Ipv4"));
            return thisTerminal;
        }

        private void MenuAccounts_Click(object sender, EventArgs e)
        {
            LabelSection.Text = "Mes comptes";
            ListFormMenu[0].BringToFront();
        }


        private void MenuOperations_Click(object sender, EventArgs e)
        {
            LabelSection.Text = "Retrait / Dépôt";
            ListFormMenu[1].BringToFront();
        }

        private void PictureLogout_Click(object sender, EventArgs e)
        {
            Close();
            Connexion.Show();
        }

        private void MenuVirement_Click(object sender, EventArgs e)
        {
            LabelSection.Text = "Virement";
            ListFormMenu[2].BringToFront();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LabelSection_Click(object sender, EventArgs e)
        {

        }
    }
}