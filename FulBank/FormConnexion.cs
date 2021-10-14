using FulBank;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form = System.Windows.Forms.Form;
using MySql.Data.MySqlClient;

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
                dbConnexion.Open();

                MySqlCommand cmdAdminSalt = new MySqlCommand("SELECT P_SALT FROM person WHERE P_ID ='" + TextUsername.Text + "'", dbConnexion);
                string AdminSalt = cmdAdminSalt.ExecuteScalar().ToString();
                string commandTextTestAdmin = "SELECT count(*) FROM admin, person WHERE A_ID = P_ID AND P_ID='" + TextUsername.Text + "' AND P_PASSWORD='" + BCrypt.Net.BCrypt.HashPassword(TextPassword.Text, AdminSalt) + "'";

                MySqlCommand cmdAdmin = new MySqlCommand(commandTextTestAdmin, dbConnexion);
                bool isAdmin = Convert.ToBoolean(int.Parse(cmdAdmin.ExecuteScalar().ToString()));
                if (isAdmin == true)
                {
                    Hide();

                    FormAdmin admin = new FormAdmin(TextUsername.Text);
                    new FormAdmin(TextUsername.Text).Show();
                    /*void ThreadProc()
                    {
                        Application.Run(new FormAdmin(TextUsername.Text));
                    }
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                    t.Start(); */
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
                        Hide();
                        void ThreadProc()
                        {
                            Application.Run(new FormMain(TextUsername.Text));
                        }
                        System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                        t.Start();
                        Close();

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
