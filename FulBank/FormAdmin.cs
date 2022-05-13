using Fulbank.classes;
using Fulbank.pages;
using FulBank.classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FulBank;

namespace Fulbank
{
    ///<summary>Class FormAdmin contains the data of the connected admin, the list of menus and the connection to the database
    ///</summary>
    public partial class FormAdmin : Form
    {
        private string _adminId;
        ///<summary>dsnConnexion contains the parameters of the connection to the database
        ///</summary>
        public static string dsnConnexion = "server=localhost;database=fulbank;uid=root;password='';SSL MODE='None'"; //préparation pour la connection à la bdd
        ///<summary>dbConnexion contains the connection to the database
        ///</summary>
        public static MySqlConnection dbConnexion = new MySqlConnection(dsnConnexion);
        ///<summary>Admin contains the admin's data
        ///</summary>
        public static Admin admin;

        List<Form> listFormAdmin = new List<Form>();
        ///<summary>Public FormAdmin is the constructor of the FormAdmin class
        ///</summary>
        public FormAdmin(string adminId)
        {
            InitializeComponent();
            _adminId = adminId;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            LoadAdminData();
            listFormAdmin.Add(new FormCreateUser(_adminId) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            panelAdmin.Controls.Add(listFormAdmin[0]);
            listFormAdmin.Add(new FormAdminProfile() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            panelAdmin.Controls.Add(listFormAdmin[1]);
            listFormAdmin.Add(new FormCreateAccount() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            panelAdmin.Controls.Add(listFormAdmin[2]);
            listFormAdmin[0].Show();
            listFormAdmin[1].Show();
            listFormAdmin[2].Show();
        }

        private void LoadAdminData()
        {
            dbConnexion.Open();
            string commandTextGetUser = "SELECT P_ID, P_NAME, P_FIRSTNAME FROM person INNER JOIN admin ON person.P_ID = admin.A_ID WHERE P_ID = ?id_person ";
            MySqlCommand cmdGetUser = new MySqlCommand(commandTextGetUser, dbConnexion);
            cmdGetUser.Parameters.AddWithValue("id_person", _adminId);
            MySqlDataReader userInfo = cmdGetUser.ExecuteReader();
            while (userInfo.Read())
            {
                admin = new Admin(int.Parse(userInfo["P_ID"].ToString()), userInfo["P_NAME"].ToString(), userInfo["P_FIRSTNAME"].ToString());
            }
            dbConnexion.Close();
        }

        private void MenuProfil_Click(object sender, EventArgs e)
        {
            listFormAdmin[1].BringToFront();

        }

        private void MenuCreateAccount_Click(object sender, EventArgs e)
        {
            listFormAdmin[0].BringToFront();

        }

        private void UserCreateNameLabel_Click(object sender, EventArgs e)
        {

        }



        private void InvalidMail_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuAccount_Click(object sender, EventArgs e)
        {
            listFormAdmin[2].BringToFront();
        }
    }
}