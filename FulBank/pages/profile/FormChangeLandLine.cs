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
    public partial class FormChangeLandLine : Form
    {
        
        public FormChangeLandLine()
        {
            InitializeComponent();
            
        }

        private void FormLandLine_Load(object sender, EventArgs e)
        {
            textOldLandLine.Text = FormMain.user.Get_homePhone();
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
            InvalidLandline.Hide();
            Regex rulePhone = new Regex(@"^(?:[\s.-]*\d{2}){5}$");
            if (rulePhone.IsMatch(textNewLandLine.Text))
            {
                if (!String.IsNullOrWhiteSpace(textNewLandLine.Text))
                {
                    FormMain.dbConnexion.Open();
                    //update landline
                    string commandTextLandLine = "UPDATE user SET U_LANDLINE = ?landline WHERE U_ID = ?id_user";
                    MySqlCommand cmdLandLine = new MySqlCommand(commandTextLandLine, FormMain.dbConnexion);
                    cmdLandLine.Parameters.AddWithValue("landline", textNewLandLine.Text);
                    cmdLandLine.Parameters.AddWithValue("id_user", FormMain.user.Get_Id());
                    cmdLandLine.ExecuteNonQuery();
                    FormMain.dbConnexion.Close();
                    FormMain.user.Set_homePhone(textNewLandLine.Text);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Entrer votre nouveau numéro de téléphone fixe");
                }
            }
            else
            {
                InvalidLandline.Show();
            }
        }
    }
}
