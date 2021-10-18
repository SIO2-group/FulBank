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
using System.Text.RegularExpressions;

namespace Fulbank.pages
{
    public partial class FormCreateAccount : Form
    {
        private string _userId;
        static string dsnConnexion = "server=localhost;database=fulbank;uid=root;password='';SSL MODE='None'"; //préparation pour la connection à la bdd
        static MySqlConnection dbConnexion = new MySqlConnection(dsnConnexion);

        public FormCreateAccount(string userId)
        {
            InitializeComponent();
            this.Text = String.Empty;
            _userId = userId;
        }

        private void FormCreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void PanelAdminCreate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserCreateButton_Click(object sender, EventArgs e)
        {
            InvalidName.Hide();
            InvalidFIrstame.Hide();
            InvalidPhone.Hide();
            NullPhone.Hide();
            InvalidLandline.Hide();
            NullLandline.Hide();
            InvalidMail.Hide();
            NullMail.Hide();
            InvalidAdress.Hide();
            InvalidPassword.Hide();
            InvalidPasswordConfirmation.Hide();
            Regex ruleName = new Regex(@"^[\p{L}]+$");
            Regex ruleMail = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9]*[a-z0-9])?)\Z");
            Regex rulePhone = new Regex(@"^(?:[\s.-]*\d{2}){5}$");
            Regex rulePassword = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&,_\-#])[A-Za-z\d@$!%*?&,_\-#]{6,}$");

            if (!String.IsNullOrWhiteSpace(UserCreateName.Text) && ruleName.IsMatch(UserCreateName.Text))
            {
                if (!String.IsNullOrWhiteSpace(UserCreateFirstname.Text) && ruleName.IsMatch(UserCreateFirstname.Text))
                {
                    if (rulePhone.IsMatch(UserCreatePhone.Text))
                    {
                        if (rulePhone.IsMatch(UserCreateLandline.Text))
                        {
                            if (ruleMail.IsMatch(UserCreateMail.Text))
                            {
                                if (!String.IsNullOrWhiteSpace(UserCreateAdress.Text))
                                {
                                    if (rulePassword.IsMatch(UserCreatePassword.Text))
                                    {
                                        if (UserCreateConfirmPassword.Text == UserCreatePassword.Text)
                                        {
                                            MessageBox.Show("Utilisateur valide");
                                            try
                                            {
                                                dbConnexion.Open();

                                                string salt = BCrypt.Net.BCrypt.GenerateSalt();
                                                string password = BCrypt.Net.BCrypt.HashPassword(UserCreatePassword.Text, salt);

                                                string insertPersonQuery = "INSERT INTO person(P_NAME, P_FIRSTNAME, P_PASSWORD, P_SALT) VALUES('" + UserCreateName.Text + "','" + UserCreateFirstname.Text + "','" + password + "','" + salt + "')";
                                                MySqlCommand cmdInsertPerson = new MySqlCommand(insertPersonQuery, dbConnexion);
                                                cmdInsertPerson.ExecuteNonQuery();

                                                string selectPersonIdQuery = "SELECT P_ID FROM PERSON WHERE P_NAME ='" + UserCreateName.Text + "' AND P_FIRSTNAME='" + UserCreateFirstname.Text + "' AND P_PASSWORD='" + password + "' ";
                                                MySqlCommand cmdSelectUserId = new MySqlCommand(selectPersonIdQuery, dbConnexion);
                                                int PersonId = int.Parse(cmdSelectUserId.ExecuteScalar().ToString());

                                                string insertUserQuery = "INSERT INTO user(U_ID, U_PHONE, U_LANDLINE, U_MAIL, U_ADRESS) VALUES('" + PersonId + "','" + UserCreatePhone.Text + "','" + UserCreateLandline.Text + "','" + UserCreateMail.Text + "','" + UserCreateAdress.Text + "')";
                                                MySqlCommand cmdInsertUser = new MySqlCommand(insertUserQuery, dbConnexion);
                                                cmdInsertUser.ExecuteNonQuery();

                                                dbConnexion.Close();

                                            }
                                            catch
                                            {

                                            }
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
                                    InvalidAdress.Show();
                                }
                            }
                            else
                            {
                                if (String.IsNullOrWhiteSpace(UserCreateMail.Text))
                                {
                                    NullMail.Show();
                                }
                                else
                                {
                                    InvalidMail.Show();
                                }
                            }
                        }
                        else
                        {
                            if (String.IsNullOrWhiteSpace(UserCreateLandline.Text))
                            {
                                NullLandline.Show();
                            }
                            else
                            {
                                InvalidLandline.Show();
                            }
                        }
                    }
                    else
                    {
                        if (String.IsNullOrWhiteSpace(UserCreatePhone.Text))
                        {
                            NullPhone.Show();
                        }
                        else
                        {
                            InvalidPhone.Show();
                        }
                    }
                }
                else
                {
                    InvalidFIrstame.Show();
                }
            }
            else
            {
                InvalidName.Show();
            }

        }
    }
}
