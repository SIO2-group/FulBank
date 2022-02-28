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
            string commandGetUser = "SELECT count(*) FROM person WHERE P_NAME = '" + AccountCreateName.Text + "' AND P_FIRSTNAME = '" + AccountCreateFirstname.Text + "'";
            MySqlCommand cmdGetUser = new MySqlCommand(commandGetUser, FormMain.dbConnexion);
            int userExist = int.Parse(cmdGetUser.ExecuteScalar().ToString());
            FormMain.dbConnexion.Close();
            if (userExist == 1)
            {
                FormMain.dbConnexion.Open();
                string insertAccountQuery = "INSERT INTO account_type(AT_NAME) VALUES('" + AccountCreateNameAccount.Text + "')";
                MySqlCommand cmdInsertAccount = new MySqlCommand(insertAccountQuery, FormMain.dbConnexion);
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
