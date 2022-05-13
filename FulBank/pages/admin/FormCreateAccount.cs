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
            FormMain.dbConnexion.Open();
            string commandGetUser = "SELECT * FROM account_type";
            MySqlCommand cmdGetUser = new MySqlCommand(commandGetUser, FormMain.dbConnexion);
            cmdGetUser.Parameters.AddWithValue("id", AccountId.Text);

            MySqlDataReader reader = cmdGetUser.ExecuteReader();

            while (reader.Read())
            {
                comboBox2.Items.Add(reader["AT_NAME"].ToString());
            }
            FormMain.dbConnexion.Close();
        }

        private void PanelAdminCreate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AccountCreateButton_Click(object sender, EventArgs e)
        {
            
        }

        private void AccountCreateFirstnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(comboBox2.Text) && !String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(overdraftLimit.Text) && double.TryParse(overdraftLimit.Text, out double result) && double.TryParse(textBox1.Text, out double result2))
            {
                FormMain.dbConnexion.Open();
                string commandGetUser = "SELECT count(*) FROM user WHERE U_ID = ?id";
                MySqlCommand cmdGetUser = new MySqlCommand(commandGetUser, FormMain.dbConnexion);
                cmdGetUser.Parameters.AddWithValue("id", textBox2.Text);
                int userExist = int.Parse(cmdGetUser.ExecuteScalar().ToString());
                FormMain.dbConnexion.Close();
                if (userExist == 1)
                {
                    FormMain.dbConnexion.Open();
                    string insertAccountQuery = "INSERT INTO account(A_ID_ACCOUNTTYPE, A_ID_USER, A_BALANCE, A_OVERDRAFT_LIMIT) VALUES((SELECT AT_ID FROM account_type WHERE AT_NAME = ?type_name), ?userId, ?balance, ?overdraft)";
                    MySqlCommand cmdInsertAccount = new MySqlCommand(insertAccountQuery, FormMain.dbConnexion);
                    cmdInsertAccount.Parameters.AddWithValue("type_name", comboBox2.SelectedItem.ToString());
                    cmdInsertAccount.Parameters.AddWithValue("userId", textBox2.Text);
                    cmdInsertAccount.Parameters.AddWithValue("balance", textBox1.Text);
                    cmdInsertAccount.Parameters.AddWithValue("overdraft", overdraftLimit.Text);
                    cmdInsertAccount.ExecuteNonQuery();
                    FormMain.dbConnexion.Close();
                    MessageBox.Show("Compte ajouté avec succès pour l'utlisateur n° " + textBox2.Text);
                }
                else
                {
                    MessageBox.Show("L'utilisateur n'existe pas");
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
