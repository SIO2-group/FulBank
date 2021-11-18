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

namespace Fulbank.pages
{
    public partial class FormChangeLandLine : Form
    {
        static string dsnConnexion = "server=localhost;database=fulbank;uid=root;password='';SSL MODE='None'"; //préparation pour la connection à la bdd
        static MySqlConnection dbConnexion = new MySqlConnection(dsnConnexion);
        private User user;
        public FormChangeLandLine(User AUser)
        {
            InitializeComponent();
            user = AUser;
        }

        private void FormLandLine_Load(object sender, EventArgs e)
        {
            textOldLandLine.Text = user.Get_homePhone();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textOldLandLine_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textNewLandLine_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNewLandLine_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textNewLandLine.Text))
            {
             dbConnexion.Open();
            string commandTextLandLine = "UPDATE user SET U_LANDLINE = '" + textNewLandLine.Text + "' WHERE U_ID = '" + user.Get_Id() + "'";
            MySqlCommand cmdLandLine = new MySqlCommand(commandTextLandLine, dbConnexion);
            cmdLandLine.ExecuteNonQuery();
            dbConnexion.Close();
            this.Close();
            }
            else
            {
                MessageBox.Show("Entrer votre nouveau numéro de téléphone fixe");
            }
        }
    }
}
