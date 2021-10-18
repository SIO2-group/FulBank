using FulBank;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using Form = System.Windows.Forms.Form;

namespace Fulbank
{
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }
        static string dsnConnexion = "server=localhost;database=fulbank;uid=root;password='';SSL MODE='None'"; //String de connection à la bdd
        static MySqlConnection dbConnexion = new MySqlConnection(dsnConnexion);

        private void FormConnexion_Load(object sender, EventArgs e)
        {

        }

        private void TextUsername_TextChanged(object sender, EventArgs e)
        {

        }



        private void ButtonValider_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnexion.Close();
                dbConnexion.Open();

                MySqlCommand cmdAdminSalt = new MySqlCommand("SELECT P_SALT FROM person WHERE P_ID ='" + TextUsername.Text + "'", dbConnexion);
                string AdminSalt = cmdAdminSalt.ExecuteScalar().ToString();
                string commandTextTestAdmin = "SELECT count(*) FROM admin, person WHERE A_ID = P_ID AND P_ID='" + TextUsername.Text + "' AND P_PASSWORD='" + BCrypt.Net.BCrypt.HashPassword(TextPassword.Text, AdminSalt) + "'";

                MySqlCommand cmdAdmin = new MySqlCommand(commandTextTestAdmin, dbConnexion);
                bool isAdmin = Convert.ToBoolean(int.Parse(cmdAdmin.ExecuteScalar().ToString()));
                if (isAdmin == true)
                {
                    Hide();
                    new FormAdmin(TextUsername.Text).Show();
                    TextUsername.Clear();
                    TextPassword.Clear();
                }
                else
                {
                    MySqlCommand cmdSalt = new MySqlCommand("SELECT P_SALT FROM person WHERE P_ID ='" + TextUsername.Text + "'", dbConnexion);
                    string userSalt = cmdSalt.ExecuteScalar().ToString();
                    string commandTextTestUser = "SELECT count(*) FROM user, person WHERE U_ID = P_ID AND P_ID='" + TextUsername.Text + "' AND P_PASSWORD='" + BCrypt.Net.BCrypt.HashPassword(TextPassword.Text, userSalt) + "'";

                    MySqlCommand cmdUser = new MySqlCommand(commandTextTestUser, dbConnexion);
                    bool isUser = Convert.ToBoolean(int.Parse(cmdUser.ExecuteScalar().ToString()));
                    if (isUser == true)
                    {
                        
                        new FormMain(TextUsername.Text, this).Show();
                        Hide();
                        TextUsername.Clear();
                        TextPassword.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Identifiant ou Mot de passe incorrect");
                    }
                }
                dbConnexion.Close();
            }
            catch
            {
                MessageBox.Show("Connexion à la base de donnée invalide");
            }


        }

        private void CheckboxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckboxShowPassword.Checked == true)
            {
                TextPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TextPassword.UseSystemPasswordChar = true;
            }
        }
    }

}
