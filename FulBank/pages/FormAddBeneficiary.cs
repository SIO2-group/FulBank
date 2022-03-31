using Fulbank.classes;
using FulBank;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fulbank.pages
{
    public partial class FormAddBeneficiary : Form
    {
        User user;
        public FormAddBeneficiary()
        {
            InitializeComponent();
           
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxBeneficiaryName.Text))
            {
                int AccountId = 0;
                bool result = int.TryParse(textBoxBeneficiaryId.Text, out AccountId);

                if (result)
                {
                    FormMain.dbConnexion.Open();
                    string commandGetAccount = "SELECT count(*) FROM account WHERE A_ID = ?id_account AND A_ID NOT IN(SELECT A_ID FROM account WHERE A_ID_USER =?id_user )";
                    MySqlCommand cmdGetAccount = new MySqlCommand(commandGetAccount, FormMain.dbConnexion);
                    cmdGetAccount.Parameters.AddWithValue("id_account", textBoxBeneficiaryId.Text);
                    cmdGetAccount.Parameters.AddWithValue("id_user", FormMain.user.Get_Id());
                    int accountExist = int.Parse(cmdGetAccount.ExecuteScalar().ToString());
                    FormMain.dbConnexion.Close();
                    if (accountExist == 1)
                    {
                        //add beneficiary
                        FormMain.user.Add_Beneficiary(int.Parse(textBoxBeneficiaryId.Text), textBoxBeneficiaryName.Text, FormMain.user.Get_Id());
                        FormMain.user.Insert_Beneficiary(int.Parse(textBoxBeneficiaryId.Text), textBoxBeneficiaryName.Text, FormMain.user.Get_Id());
                        MessageBox.Show("Bénéficiaire " + textBoxBeneficiaryName.Text + " ajouté avec succès");   
                    }
                    else
                    {
                        MessageBox.Show("Ce compte vous appartient ou n'existe pas");
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Veuillez entrer un identifiant uniquement composé de chiffres");
                }
                

            }
            else
            {
                MessageBox.Show("Veuillez entrer un nom pour votre bénéficiaire");
            }
            
            
        }

        private void textBoxBeneficiaryId_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAddBeneficiary_Load(object sender, EventArgs e)
        {

        }
    }
}
