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
                try {
                    string commandtext = "SELECT count(*) FROM user WHERE ID_P='" + TextUsername.Text + "' AND PASSWORD='" + TextPassword.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(commandtext, dbConnexion);
                    int result = int.Parse(cmd.ExecuteScalar().ToString());
                    if (result == 1)
                    {
                        Hide();
                        FormMain form = new FormMain();
                        form.Show();
                    }
                    else
                    {

                        MessageBox.Show("Identifiant ou Mot de passe incorrect");

                    }
                }
                catch
                {
                    MessageBox.Show("géfaim");
                }
                    

                

            }
            catch
            {
                MessageBox.Show("Echec niktamere");
            }

            


        }
    }

    
}
