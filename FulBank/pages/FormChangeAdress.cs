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
    public partial class FormChangeAdress : Form
    {
        static string dsnConnexion = "server=localhost;database=fulbank;uid=root;password='';SSL MODE='None'"; //préparation pour la connection à la bdd
        static MySqlConnection dbConnexion = new MySqlConnection(dsnConnexion);
        private User user;
        public FormChangeAdress(User AUser)
        {
            InitializeComponent();
            user = AUser;
        }

        private void FormChangeAdress_Load(object sender, EventArgs e)
        {
            textOldAdress.Text = user.Get_address();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewAdress_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textNewAdress.Text))
            {
                dbConnexion.Open();
                string commandTextAdress = "UPDATE user SET U_ADRESS = '" + textNewAdress.Text + "' WHERE U_ID = '" + user.Get_Id() + "'";
                MySqlCommand cmdAdress = new MySqlCommand(commandTextAdress, dbConnexion);
                cmdAdress.ExecuteNonQuery();
                dbConnexion.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Entrer votre nouvelle adresse");
            }
        }
    }
}
