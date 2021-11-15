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
        public FormAddBeneficiary(User aUser)
        {
            InitializeComponent();
            user = aUser;
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
                    string commandGetAccount = "SELECT count(*) FROM account WHERE A_ID = '" + textBoxBeneficiaryId.Text + "' AND A_ID NOT IN(SELECT A_ID FROM account WHERE A_ID_USER ='" + user.Get_Id() + "' )";
                    MySqlCommand cmdGetAccount = new MySqlCommand(commandGetAccount, FormMain.dbConnexion);
                    bool accountExist = Convert.ToBoolean(int.Parse(cmdGetAccount.ExecuteScalar().ToString()));
                    FormMain.dbConnexion.Close();
                    if (accountExist == true)
                    {
                        user.Add_Beneficiary(int.Parse(textBoxBeneficiaryId.Text), textBoxBeneficiaryName.Text, user.Get_Id());
                        MessageBox.Show("Bénéficiaire " + user.GetBeneficiary()[0].getBeneficiaryName() + " ajouté avec succès");   
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
    }
}
