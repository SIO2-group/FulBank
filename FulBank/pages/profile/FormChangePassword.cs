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
using Fulbank.classes;
using FulBank;
using System.Text.RegularExpressions;

namespace Fulbank.pages
{
    public partial class FormChangePassword : Form
    {
        public FormChangePassword()
        {
            InitializeComponent();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnNewPassword_Click(object sender, EventArgs e)
        {
            InvalidPassword.Hide();
            InvalidPasswordConfirmation.Hide();
            Regex rulePassword = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&,_\-#])[A-Za-z\d@$!%*?&,_\-#]{6,}$");
            if (!String.IsNullOrWhiteSpace(textOldPassword.Text))
            {
                if (!String.IsNullOrWhiteSpace(textNewPassword.Text))
                {
                    if (!String.IsNullOrWhiteSpace(textConfirmPassword.Text))
                    {

                        FormMain.dbConnexion.Open();
                        MySqlCommand cmdSalt = new MySqlCommand("SELECT P_SALT FROM person WHERE P_ID ='" + FormMain.user.Get_Id() + "'", FormMain.dbConnexion);
                        string userSalt = cmdSalt.ExecuteScalar().ToString();
                        string commandTextTestUser = "SELECT count(*) FROM user, person WHERE U_ID = P_ID AND P_ID=?id_user AND P_PASSWORD=?password";

                        MySqlCommand cmdUser = new MySqlCommand(commandTextTestUser, FormMain.dbConnexion);
                        cmdUser.Parameters.AddWithValue("id_user", FormMain.user.Get_Id());
                        cmdUser.Parameters.AddWithValue("password", BCrypt.Net.BCrypt.HashPassword(textOldPassword.Text, userSalt));
                        bool isUser = Convert.ToBoolean(int.Parse(cmdUser.ExecuteScalar().ToString()));
                        FormMain.dbConnexion.Close();
                        if (isUser == true)
                        {
                            if (rulePassword.IsMatch(textNewPassword.Text))
                            {
                                if (textConfirmPassword.Text == textNewPassword.Text)
                                {

                                    FormMain.dbConnexion.Open();

                                    string salt = BCrypt.Net.BCrypt.GenerateSalt();
                                    string password = BCrypt.Net.BCrypt.HashPassword(textNewPassword.Text, salt);

                                    string updatePersonQuery = "UPDATE person SET P_PASSWORD = ?password, P_SALT = ?salt";
                                    MySqlCommand cmdUpdatePerson = new MySqlCommand(updatePersonQuery, FormMain.dbConnexion);
                                    cmdUpdatePerson.Parameters.AddWithValue("password", password);
                                    cmdUpdatePerson.Parameters.AddWithValue("salt", salt);
                                    cmdUpdatePerson.ExecuteNonQuery();


                                    FormMain.dbConnexion.Close();
                                    
                                    MessageBox.Show("Mot de Passe modifié");



                                }
                                else
                                {
                                    InvalidPasswordConfirmation.Show();
                                }


                            }
                            else
                            {
                                InvalidPassword.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("mot de passe incorrect");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Le champ Comfirmer votre nouveau mot de passe est vide!");
                    }
                }
                else
                {
                    MessageBox.Show("Le champ votre nouveau mot de passe est vide!");
                }
            }
            else
            {
                MessageBox.Show("Le champ votre ancien mot de passe est vide!");
            }
        }

        }
}
