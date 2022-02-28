using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Fulbank.pages
{
    public partial class FormCreateUser : Form
    {
        static string dsnConnexion = "server=localhost;database=fulbank;uid=root;password='';SSL MODE='None'"; //préparation pour la connection à la bdd
        static MySqlConnection dbConnexion = new MySqlConnection(dsnConnexion);
        // MySqlConnection dbConnexion = FormMain.getConnexion();
        private string _userId;
        public FormCreateUser(string aUserId)
        {
            InitializeComponent();
            _userId = aUserId;
            this.Text = String.Empty;
            this.ControlBox = false;
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
                                            try
                                            {
                                                dbConnexion.Open();

                                                string salt = BCrypt.Net.BCrypt.GenerateSalt();
                                                string password = BCrypt.Net.BCrypt.HashPassword(UserCreatePassword.Text, salt);

                                                string insertPersonQuery = "INSERT INTO person(P_NAME, P_FIRSTNAME, P_PASSWORD, P_SALT) VALUES('" + UserCreateName.Text + "','" + UserCreateFirstname.Text + "','" + password + "','" + salt + "')";
                                                MySqlCommand cmdInsertPerson = new MySqlCommand(insertPersonQuery, dbConnexion);
                                                cmdInsertPerson.ExecuteNonQuery();
                                                
                                                string insertUserQuery = "INSERT INTO user(U_ID, U_PHONE, U_LANDLINE, U_MAIL, U_ADRESS) VALUES((SELECT P_ID FROM PERSON WHERE P_NAME ='" + UserCreateName.Text + "' AND P_FIRSTNAME='" + UserCreateFirstname.Text + "' AND P_PASSWORD='" + password + "'),'" + UserCreatePhone.Text + "','" + UserCreateLandline.Text + "','" + UserCreateMail.Text + "','" + UserCreateAdress.Text + "')";
                                                MySqlCommand cmdInsertUser = new MySqlCommand(insertUserQuery, dbConnexion);
                                                cmdInsertUser.ExecuteNonQuery();
                                                dbConnexion.Close();
                                                MessageBox.Show("Utilisateur entré");

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
