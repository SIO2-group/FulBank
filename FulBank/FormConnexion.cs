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

        static string dsnConnexion = "server=localhost;database=fulbank;uid=root;password='';SSL MODE='None'"; //préparation pour la connection à la bdd
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
                string commandTextTestAdmin = "SELECT count(*) FROM admin WHERE ID_P='" + TextUsername.Text + "' AND PASSWORD='" + TextPassword.Text + "'";
                MySqlCommand cmdAdmin = new MySqlCommand(commandTextTestAdmin, dbConnexion);
                bool isAdmin = Convert.ToBoolean(int.Parse(cmdAdmin.ExecuteScalar().ToString()));
                if (isAdmin == true)
                {
                    Hide();
                    FormAdmin admin = new FormAdmin(TextUsername.Text);
                    admin.Show();
                }
                else
                {
                    string commandTextTestUser = "SELECT count(*) FROM user WHERE ID_P='" + TextUsername.Text + "' AND PASSWORD='" + TextPassword.Text + "'";
                    MySqlCommand cmdUser = new MySqlCommand(commandTextTestUser, dbConnexion);
                    bool isUser = Convert.ToBoolean(int.Parse(cmdUser.ExecuteScalar().ToString()));
                    if (isUser == true)
                    {
                        Hide();
                        FormMain user = new FormMain(TextUsername.Text);
                        user.Show();

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
