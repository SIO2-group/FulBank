using Fulbank.pages;
using Fulbank.classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace FulBank
{

    public partial class FormMain : System.Windows.Forms.Form
    {
        private string _userId;
        static string dsnConnexion = "server=localhost;database=fulbank;uid=root;password='';SSL MODE='None'"; //préparation pour la connection à la bdd
        static MySqlConnection dbConnexion = new MySqlConnection(dsnConnexion);
        public static List<Form> ListFormMenu = new List<Form>();
        Form Connexion;
        User user;
        

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
            ListFormMenu.Add(new FormAccount(user) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            panelMain.Controls.Add(ListFormMenu[0]);
            ListFormMenu.Add(new FormOperation(user) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            panelMain.Controls.Add(ListFormMenu[1]);
            ListFormMenu.Add(new FormTransfer(user) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            panelMain.Controls.Add(ListFormMenu[2]);
            ListFormMenu[2].Show();
            ListFormMenu[1].Show();
            ListFormMenu[0].Show();

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
            return aUser;
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
    }
}