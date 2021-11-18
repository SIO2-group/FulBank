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
    public partial class FormChangeMail : Form
    {
        static string dsnConnexion = "server=localhost;database=fulbank;uid=root;password='';SSL MODE='None'"; //préparation pour la connection à la bdd
        static MySqlConnection dbConnexion = new MySqlConnection(dsnConnexion);
        private User user;
        public FormChangeMail(User AUser)
        {
            InitializeComponent();
            user = AUser;
        }

        private void FormChangeMail_Load(object sender, EventArgs e)
        {
            textOldMail.Text = user.Get_email();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewMail_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textNewMail.Text))
            {
            dbConnexion.Open();
            string commandTextMail = "UPDATE user SET U_MAIL = '" + textNewMail.Text + "' WHERE U_ID = '" + user.Get_Id() + "'";
            MySqlCommand cmdMail = new MySqlCommand(commandTextMail, dbConnexion);
            cmdMail.ExecuteNonQuery();
            dbConnexion.Close();
            this.Close();
            }
            else
            {
                MessageBox.Show("Entrer votre nouvelle adresse mail");
            }
        }
    }
}
