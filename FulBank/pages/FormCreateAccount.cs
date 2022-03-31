using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using FulBank;

namespace Fulbank.pages
{
    public partial class FormCreateAccount : Form
    {
        
        public FormCreateAccount()
        {
            InitializeComponent();
            
            this.Text = String.Empty;
            this.ControlBox = false;
        }

        private void FormCreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void PanelAdminCreate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AccountCreateButton_Click(object sender, EventArgs e)
        {
            FormMain.dbConnexion.Open();
           
            string commandGetUser = "SELECT count(*) FROM person WHERE P_NAME = ?name AND P_FIRSTNAME = ?firstanme";
            MySqlCommand cmdGetUser = new MySqlCommand(commandGetUser, FormMain.dbConnexion);
            cmdGetUser.Parameters.AddWithValue("name", AccountCreateName.Text);
            cmdGetUser.Parameters.AddWithValue("firstname", AccountCreateFirstname.Text);
            int userExist = int.Parse(cmdGetUser.ExecuteScalar().ToString());
            FormMain.dbConnexion.Close();
            if (userExist == 1)
            {
                FormMain.dbConnexion.Open();
                //adding an account type
                string insertAccountQuery = "INSERT INTO account_type(AT_NAME) VALUES(?type_name)";
                MySqlCommand cmdInsertAccount = new MySqlCommand(insertAccountQuery, FormMain.dbConnexion);
                cmdInsertAccount.Parameters.AddWithValue("type_name", AccountCreateNameAccount.Text);
                cmdInsertAccount.ExecuteNonQuery();
                FormMain.dbConnexion.Close();
                MessageBox.Show("Compte " + AccountCreateNameAccount.Text + " ajouté avec succès pour l'utlisateur " + AccountCreateName.Text +" "+ AccountCreateFirstname.Text);
            }
            else
            {
                MessageBox.Show("L'utilisateur n'existe pas");
            }
        }
    }
}
