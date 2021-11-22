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
    public partial class FormChangePhone : Form
    {
       
        public FormChangePhone()
        {
            InitializeComponent();
            

        }

        private void FormChangePhone_Load(object sender, EventArgs e)
        {
            textOldPhone.Text = FormMain.user.Get_phone();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewPhone_Click(object sender, EventArgs e)
        {
            InvalidPhone.Hide();
            Regex rulePhone = new Regex(@"^(?:[\s.-]*\d{2}){5}$");
            if (rulePhone.IsMatch(textNewPhone.Text))
            {
                if (!String.IsNullOrWhiteSpace(textNewPhone.Text))
                {
                    FormMain.dbConnexion.Open();
                    string commandTextPhone = "UPDATE user SET U_PHONE = '" + textNewPhone.Text + "' WHERE U_ID = '" + FormMain.user.Get_Id() + "'";
                    MySqlCommand cmdPhone = new MySqlCommand(commandTextPhone, FormMain.dbConnexion);
                    cmdPhone.ExecuteNonQuery();
                    FormMain.dbConnexion.Close();
                    FormMain.user.Set_phone(textNewPhone.Text);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Entrer votre nouveau numéro de téléphone");
                }
            }
            else
            {
                InvalidPhone.Show();
            }
            } 
    }
}
