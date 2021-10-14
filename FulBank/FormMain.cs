using Fulbank;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Fulbank.pages;


namespace FulBank
{

    public partial class FormMain: System.Windows.Forms.Form
    {
        private string _userId;
        static string dsnConnexion = "server=localhost;database=fulbank;uid=root;password='';SSL MODE='None'"; //préparation pour la connection à la bdd
        static MySqlConnection dbConnexion = new MySqlConnection(dsnConnexion);
        List<Form> ListFormMenu = new List<Form>();
        
        public MySqlConnection getConnexion()
        {
            return dbConnexion;
        }
        

        public FormMain(string userId)
        {
            InitializeComponent();
            _userId = userId;
        }
        

        private void FormMain_Load(object sender, EventArgs e)
        {
            ListFormMenu.Add(new FormAccount(_userId) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            panelMain.Controls.Add(ListFormMenu[0]);
            ListFormMenu.Add(new FormOperation(_userId) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            panelMain.Controls.Add(ListFormMenu[1]);
            ListFormMenu[1].Show();
            ListFormMenu[0].Show();
        }



        private void MenuAccounts_Click(object sender, EventArgs e)
        {
            ListFormMenu[0].BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Balance_Click(object sender, EventArgs e)
        {

        }

        private void AccountNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumberAccount_Click(object sender, EventArgs e)
        {

        }

        private void AccountBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void Owner_Click(object sender, EventArgs e)
        {

        }

        private void AccountOwner_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelAccount4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuOperations_Click(object sender, EventArgs e)
        {
            ListFormMenu[1].BringToFront();
        }

        private void panelAccounts_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}