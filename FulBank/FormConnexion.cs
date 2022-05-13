using FulBank;
using FulBank.classes;
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
        static MySqlConnection dbConnexion = FormMain.dbConnexion;

        private void FormConnexion_Load(object sender, EventArgs e)
        {
            IniFile MyIni = new IniFile("Fulbank.ini");

            if (MyIni.KeyExists("Id"))
            {
                if(int.TryParse(MyIni.Read("Id"), out int Id))
                { 
                    string address = "";
                    if (MyIni.KeyExists("Address"))
                    {
                        address = MyIni.Read("Address");
                    }

                    dbConnexion.Open();
                    string cmd = "INSERT INTO terminal (TL_ID, TL_ADDRESS) VALUES (?id, ?address) ON DUPLICATE KEY UPDATE TL_ADDRESS = ?address";
                    MySqlCommand command = new MySqlCommand(cmd, dbConnexion);
                    command.Parameters.AddWithValue("id", Id);
                    command.Parameters.AddWithValue("address", address);
                    command.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Identifiant de la borne invalide");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Veuillez configurer la borne");
                this.Close();
            }
        }

        private void TextUsername_TextChanged(object sender, EventArgs e)
        {

        }



        private void ButtonValider_Click(object sender, EventArgs e)
        {

            dbConnexion.Close();
            dbConnexion.Open();

            MySqlCommand cmdAdmin = new MySqlCommand(@"SELECT P_PASSWORD FROM admin
                                                        INNER JOIN person ON admin.A_ID = person.P_ID
                                                        WHERE admin.A_ID = ?username", dbConnexion);
            cmdAdmin.Parameters.AddWithValue("username", TextUsername.Text);
            object password = cmdAdmin.ExecuteScalar();
            bool test = false;
            if (password != null)
            {
                test = BCrypt.Net.BCrypt.Verify(TextPassword.Text, password.ToString());
            }

            if (test)
            {
                Hide();
                dbConnexion.Close();
                new FormAdmin(TextUsername.Text).Show();
                TextUsername.Clear();
                TextPassword.Clear();
            }
            else
            {
                MySqlCommand cmdUser = new MySqlCommand(@"SELECT P_PASSWORD FROM user
                                                        INNER JOIN person ON user.U_ID = person.P_ID
                                                        WHERE user.U_ID = ?username", dbConnexion);
                cmdUser.Parameters.AddWithValue("username", TextUsername.Text);
                object passwordUser = cmdUser.ExecuteScalar();
                bool testUser = false;
                if (passwordUser != null)
                {
                    testUser = BCrypt.Net.BCrypt.Verify(TextPassword.Text, passwordUser.ToString());
                }

                if (testUser)
                {
                    dbConnexion.Close();
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

        private void TextPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
