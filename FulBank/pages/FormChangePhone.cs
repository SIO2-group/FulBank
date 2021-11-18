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
using FulBank;

namespace Fulbank.pages
{
    public partial class FormChangePhone : Form
    {
        static string dsnConnexion = "server=localhost;database=fulbank;uid=root;password='';SSL MODE='None'"; //préparation pour la connection à la bdd
        static MySqlConnection dbConnexion = new MySqlConnection(dsnConnexion);
        private User user;
        public FormChangePhone(User AUser)
        {
            InitializeComponent();
            user = AUser;

        }

        private void FormChangePhone_Load(object sender, EventArgs e)
        {
            textOldPhone.Text = user.Get_phone();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewPhone_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textNewPhone.Text))
                {
                dbConnexion.Open();
                string commandTextPhone = "UPDATE user SET U_PHONE = '" + textNewPhone.Text + "' WHERE U_ID = '" + user.Get_Id() + "'";
                MySqlCommand cmdPhone = new MySqlCommand(commandTextPhone, dbConnexion);
                cmdPhone.ExecuteNonQuery();
                dbConnexion.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Entrer votre nouveau numéro de téléphone");
            }
        } 
    }
}
