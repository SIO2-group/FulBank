using Fulbank.pages;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fulbank
{
    public partial class FormAdmin : Form
    {
        private string _userId;
        static string dsnConnexion = "server=localhost;database=fulbank;uid=root;password='';SSL MODE='None'"; //préparation pour la connection à la bdd
        static MySqlConnection dbConnexion = new MySqlConnection(dsnConnexion);

        List<Form> listFormAdmin = new List<Form>();

        public FormAdmin(string userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            listFormAdmin.Add(new FormCreateUser(_userId) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            panelAdmin.Controls.Add(listFormAdmin[0]);
            listFormAdmin.Add(new FormAdminProfile(_userId) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            panelAdmin.Controls.Add(listFormAdmin[1]);
            listFormAdmin[1].Show();
            listFormAdmin[0].Show();
        }

        private void LoadAdminData()
        {

        }

        private void MenuProfil_Click(object sender, EventArgs e)
        {
            listFormAdmin[0].BringToFront();

        }

        private void MenuCreateAccount_Click(object sender, EventArgs e)
        {
            listFormAdmin[1].BringToFront();

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
    }
}