using Fulbank.pages;
using Fulbank.classes;
using FulBank.classes;
using Fulbank.pages.Crypto;
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace FulBank
{
    ///<summary>Class FormMain contains the data of the connected user, the list of menus and the connection to the database
    ///</summary>
    public partial class FormMain : System.Windows.Forms.Form
    {
        private string _userId;
        ///<summary>dsnConnexion contains the parameters of the connection to the database
        ///</summary>
        public static string dsnConnexion = "server=localhost;database=fulbank;uid=root;password='';SSL MODE='None'"; //préparation pour la connection à la bdd
        ///<summary>dbConnexion contains the connection to the database
        ///</summary>
        public static MySqlConnection dbConnexion = new MySqlConnection(dsnConnexion);
        ///<summary>ListFormMenu contains the list of menus
        ///</summary>
        public static List<Form> ListFormMenu = new List<Form>();
        public static Form Connexion;
        ///<summary>User contains the user's data
        ///</summary>
        public static User user;
        public static Terminal thisTerminal;
        public static RootRates ConversionRates = new RootRates();

        public MySqlConnection getConnexion()
        {
            return dbConnexion;
        }

        ///<summary>Public FormMain is the constructor of the FormMain class
        ///</summary>
        public FormMain(string userId, Form FormCo)
        {
            InitializeComponent();
            _userId = userId;
            Connexion = FormCo;

            try
            {
                WebRequest request = HttpWebRequest.Create("https://api.frankfurter.app/latest?from=USD");
                WebResponse response = request.GetResponse();

                StreamReader reader = new StreamReader(response.GetResponseStream());

                string rates_json = reader.ReadToEnd();

                ConversionRates = JsonConvert.DeserializeObject<RootRates>(rates_json);
            }
            catch 
            { 
                MessageBox.Show("Initialisation des taux de conversion invalide"); 
            }

        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            user = UserDataLoad();
            thisTerminal = TerminalLoad();
            //forms(pages) are added to the menu
            ListFormMenu.Add(new FormAccount() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            panelMain.Controls.Add(ListFormMenu[0]);
            ListFormMenu.Add(new FormOperation() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            panelMain.Controls.Add(ListFormMenu[1]);
            ListFormMenu.Add(new FormTransfer() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            panelMain.Controls.Add(ListFormMenu[2]);
            ListFormMenu.Add(new FormOperationHistory() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            panelMain.Controls.Add(ListFormMenu[3]);
            ListFormMenu.Add(new FormProfile() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            panelMain.Controls.Add(ListFormMenu[4]);
            ListFormMenu.Add(new FormTransferHistory() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            panelMain.Controls.Add(ListFormMenu[5]);            
            ListFormMenu.Add(new FormCryptocurrency() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            panelMain.Controls.Add(ListFormMenu[6]);
            ListFormMenu[6].Show();
            ListFormMenu[5].Show();
            ListFormMenu[4].Show();
            ListFormMenu[3].Show();
            ListFormMenu[2].Show();
            ListFormMenu[1].Show();
            ListFormMenu[0].Show();
            ListFormMenu[0].BringToFront();
        }

        private User UserDataLoad()
        {
            #region user initialisation
            dbConnexion.Open();
            string commandTextGetUser = "SELECT P_ID, P_NAME, P_FIRSTNAME, U_PHONE, U_LANDLINE, U_MAIL, U_ADRESS FROM person INNER JOIN user ON person.P_ID = user.U_ID WHERE P_ID = ?id_user ";
            MySqlCommand cmdGetUser = new MySqlCommand(commandTextGetUser, dbConnexion);
            cmdGetUser.Parameters.AddWithValue("id_user", _userId);
            MySqlDataReader userInfo = cmdGetUser.ExecuteReader();
            userInfo.Read();
            User aUser = new User(int.Parse(userInfo["P_ID"].ToString()), userInfo["P_NAME"].ToString(), userInfo["P_FIRSTNAME"].ToString(), userInfo["U_MAIL"].ToString(), userInfo["U_PHONE"].ToString(), userInfo["U_LANDLINE"].ToString(), userInfo["U_ADRESS"].ToString());
            dbConnexion.Close();
            #endregion
            #region user accounts load
            dbConnexion.Open();
            string commandTextTestUser = "SELECT A_ID, A_ID_ACCOUNTTYPE, A_BALANCE, A_OVERDRAFT_LIMIT FROM account WHERE A_ID_USER = ?id_user ";
            MySqlCommand cmdGetUserAccounts = new MySqlCommand(commandTextTestUser, dbConnexion);
            cmdGetUserAccounts.Parameters.AddWithValue("id_user", _userId);
            MySqlDataReader userAccounts = cmdGetUserAccounts.ExecuteReader();
            

            while (userAccounts.Read())
            {
                aUser.Add_Account(int.Parse(userAccounts["A_ID"].ToString()), int.Parse(userAccounts["A_ID_ACCOUNTTYPE"].ToString()), double.Parse(userAccounts["A_BALANCE"].ToString().Replace(".",",")), int.Parse(userAccounts["A_OVERDRAFT_LIMIT"].ToString()));
            }

            dbConnexion.Close();

            #endregion
            #region user accounts operation load
            Account accounts = aUser.GetAccounts()[0];
                dbConnexion.Open();
                string commandTextoperation = "SELECT OP_ID, OP_AMOUNT, OP_ISDEBIT, DATE_FORMAT(OP_DATE,'%d-%m-%Y %H:%i:%s') as OP_DATE FROM account INNER JOIN operation ON account.A_ID = operation.OP_ID_ACCOUNT WHERE OP_ID_ACCOUNT = ?id_account ORDER BY OP_ID DESC";
                MySqlCommand cmdGetoperation = new MySqlCommand(commandTextoperation, dbConnexion);
                cmdGetoperation.Parameters.AddWithValue("id_account", accounts.Get_Id());

                MySqlDataReader operation = cmdGetoperation.ExecuteReader();
                while (operation.Read())
                {
                    DateTime dt = DateTime.Parse(operation["OP_DATE"].ToString());
                    accounts.Add_Operation(int.Parse(operation["OP_ID"].ToString()), double.Parse(operation["OP_AMOUNT"].ToString()), Convert.ToBoolean(operation["OP_ISDEBIT"].ToString()), dt );
                } 
                dbConnexion.Close();

            #endregion
            #region user transation beneficiaries load
            dbConnexion.Open();
            string commandTextSelectBeneficiary = "SELECT * FROM beneficiary WHERE B_USER_ID = ?id_user";
            MySqlCommand cmdSelectBeneficiary = new MySqlCommand(commandTextSelectBeneficiary, dbConnexion);
            cmdSelectBeneficiary.Parameters.AddWithValue("id_user", _userId);
            MySqlDataReader userBeneficiaries = cmdSelectBeneficiary.ExecuteReader();


            while(userBeneficiaries.Read())
            {
                aUser.Add_Beneficiary(int.Parse(userBeneficiaries["B_ACCOUNT_ID"].ToString()), userBeneficiaries["B_NAME"].ToString(), int.Parse(_userId));
            }

            dbConnexion.Close();
            #endregion
            #region user cryptowallets load
            dbConnexion.Open();

            string commandTextSelectWallets = "SELECT * FROM cryptowallet WHERE CW_UID = ?id_user";
            MySqlCommand cmdSelectWallets = new MySqlCommand(commandTextSelectWallets, dbConnexion);
            cmdSelectWallets.Parameters.AddWithValue("id_user", _userId);
            MySqlDataReader Wallets = cmdSelectWallets.ExecuteReader();              

            while (Wallets.Read())
            {
                //while (crypto_op.Read())
                    aUser.AddWallet(int.Parse(Wallets["CW_ID"].ToString()) , Wallets["CW_C_SYMBOL"].ToString(), float.Parse(Wallets["CW_AMOUNT"].ToString()));
            }

            dbConnexion.Close();
            dbConnexion.Open();

            string commandTextSelectOp = @"SELECT *
                                            FROM crypto_trade
                                            WHERE WALLET_ID = ?id";
            MySqlCommand cmdSelectOp = new MySqlCommand(commandTextSelectOp, FormMain.dbConnexion);
            cmdSelectOp.Parameters.AddWithValue("id", _userId);
            MySqlDataReader crypto_op = cmdSelectOp.ExecuteReader();

            dbConnexion.Close();
            
            #endregion
            #region add transfers
            dbConnexion.Open();
            string commandTextSelectTransfer = @"SELECT T_ID_ACCOUNT_FROM, T_ID_ACCOUNT_TO, T_AMOUNT, DATE_FORMAT(T_DATE,'%d-%m-%Y %H:%i:%s') as T_DATE
                                            FROM transaction
                                            WHERE T_ID_ACCOUNT_FROM IN(SELECT A_ID
                                                                        FROM account
                                                                        WHERE A_ID_USER = ?id_user)";
            MySqlCommand cmdSelectTransfer = new MySqlCommand(commandTextSelectTransfer, FormMain.dbConnexion);
            cmdSelectTransfer.Parameters.AddWithValue("id_user", aUser.Get_Id());
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
            Terminal thisTerminal = new Terminal(MyIni.Read("Id"), MyIni.Read("City"), MyIni.Read("Building"), MyIni.Read("Ipv4"), MyIni.Read("CP"));
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
            ListFormMenu.Clear();
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


        private void MenuProfil_Click(object sender, EventArgs e)
        {
            LabelSection.Text = "Mon Profil";
            ListFormMenu[4].BringToFront();

        }

        private void MenuCrypto_Click(object sender, EventArgs e)
        {
            LabelSection.Text = "Cryptomonnaies";
            ListFormMenu[6].BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
