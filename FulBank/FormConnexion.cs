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
using MySql.Data;
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

            Close();
        }

        private void ButtonValider_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnexion.Open();
                dbConnexion.Close();
                FormMain main = new FormMain();
                main.Show();
            }
            catch
            {
                MessageBox.Show("Connexion échouée");
                Close();
            }
            
        }
    }

    
}
