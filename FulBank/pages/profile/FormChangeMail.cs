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
using System.Text.RegularExpressions;

namespace Fulbank.pages
{
    public partial class FormChangeMail : Form
    {
        
        public FormChangeMail()
        {
            InitializeComponent();
            
        }

        private void FormChangeMail_Load(object sender, EventArgs e)
        {
            textOldMail.Text = FormMain.user.Get_email();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewMail_Click(object sender, EventArgs e)
        {
            InvalidMail.Hide();
            Regex ruleMail = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9]*[a-z0-9])?)\Z");
            if (ruleMail.IsMatch(textNewMail.Text))
            {
                if (!String.IsNullOrWhiteSpace(textNewMail.Text))
                {
                    FormMain.dbConnexion.Open();
                    string commandTextMail = "UPDATE user SET U_MAIL = ?mail WHERE U_ID = ?id_user";
                    MySqlCommand cmdMail = new MySqlCommand(commandTextMail, FormMain.dbConnexion);
                    cmdMail.Parameters.AddWithValue("mail", textNewMail.Text);
                    cmdMail.Parameters.AddWithValue("id_user", FormMain.user.Get_Id());
                    cmdMail.ExecuteNonQuery();
                    FormMain.dbConnexion.Close();
                    FormMain.user.Set_email(textNewMail.Text);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Entrer votre nouvelle adresse mail");
                }
            }
            else
            {
                InvalidMail.Show();
            }
            }
    }
}
