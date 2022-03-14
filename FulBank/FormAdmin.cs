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
    public partial class FormAdmin : Form
    {
        private string _adminId;
        public static string dsnConnexion = "server=localhost;database=fulbank;uid=root;password='';SSL MODE='None'"; //préparation pour la connection à la bdd
        public static MySqlConnection dbConnexion = new MySqlConnection(dsnConnexion);

        public static Admin admin;
        List<Form> listFormAdmin = new List<Form>();

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
            listFormAdmin.Add(new FormTerminalConf() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            panelAdmin.Controls.Add(listFormAdmin[2]);
            listFormAdmin.Add(new FormCreateAccount() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            panelAdmin.Controls.Add(listFormAdmin[3]);
            listFormAdmin[0].Show();
            listFormAdmin[1].Show();
            listFormAdmin[2].Show();
            listFormAdmin[3].Show();
        }

        private void LoadAdminData()
        {
            dbConnexion.Open();
            string commandTextGetUser = "SELECT P_ID, P_NAME, P_FIRSTNAME FROM person INNER JOIN admin ON person.P_ID = admin.A_ID WHERE P_ID = ?id_person ";
            MySqlCommand cmdGetUser = new MySqlCommand(commandTextGetUser, dbConnexion);
            cmdGetUser.Parameters.AddWithValue("id_person", _adminId);
            MySqlDataReader userInfo = cmdGetUser.ExecuteReader();
            userInfo.Read();
            admin = new Admin(int.Parse(userInfo["P_ID"].ToString()), userInfo["P_NAME"].ToString(), userInfo["P_FIRSTNAME"].ToString());
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

        private void MenuTerminalConfig_Click(object sender, EventArgs e)
        {
            listFormAdmin[2].BringToFront();

        }

        private void MenuAccount_Click(object sender, EventArgs e)
        {
            listFormAdmin[3].BringToFront();
        }
    }
}