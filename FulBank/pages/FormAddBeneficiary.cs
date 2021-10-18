using Fulbank.classes;
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
                int AccountId;
                bool result = int.TryParse(textBoxBeneficiaryId.Text, out AccountId);

                if (result)
                {
                    user.Add_Beneficiary(int.Parse(textBoxBeneficiaryId.Text), textBoxBeneficiaryName.Text, user.Get_Id());
                    MessageBox.Show(user.GetBeneficiary()[0].getBeneficiaryName());
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
