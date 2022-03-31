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
    public partial class FormChangeAdress : Form
    {
        
        public FormChangeAdress()
        {
            InitializeComponent();
            
        }

        private void FormChangeAdress_Load(object sender, EventArgs e)
        {
            textOldAdress.Text = FormMain.user.Get_address();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewAdress_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textNewAdress.Text))
            {
                FormMain.dbConnexion.Open();
                //update adress
                string commandTextAdress = "UPDATE user SET U_ADRESS = ?adress WHERE U_ID = ?id_user";
                MySqlCommand cmdAdress = new MySqlCommand(commandTextAdress, FormMain.dbConnexion);
                cmdAdress.Parameters.AddWithValue("adress", textNewAdress.Text);
                cmdAdress.Parameters.AddWithValue("id_user", FormMain.user.Get_Id());
                cmdAdress.ExecuteNonQuery();
                FormMain.dbConnexion.Close();
                FormMain.user.Set_address(textNewAdress.Text);
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Entrer votre nouvelle adresse");
            }
        }
    }
}
