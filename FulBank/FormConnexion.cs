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

        static string dsnConnection = "server=localhost;database=reigns;uid=root;password='';SSL MODE='None'"; //préparation pour la connection à la bdd
        static MySqlConnection dbConnection = new MySqlConnection(dsnConnection);

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
                dbConnection.Open();
            }
            catch
            {
                MessageBox.Show("Connexion échouée");
                Close();
            }
            
        }
    }

    
}
