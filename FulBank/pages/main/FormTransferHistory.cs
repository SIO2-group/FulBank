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
    public partial class FormTransferHistory : Form
    {
        public FormTransferHistory()
        {
            InitializeComponent();
            this.Text = String.Empty;
            this.ControlBox = false;
        }

        private void FormTransferHistory_Load(object sender, EventArgs e)
        {

            List<Transfer> transfers = FormMain.user.getTransfers();
            foreach(Transfer transfer in transfers)
            {
                string aFromName = "Erreur";
                string aToName = "Erreur";
                foreach(Account account in FormMain.user.GetAccounts())
                {
                    if (account.Get_Id() == transfer.getAccountFrom().Get_Id())
                    {
                        aFromName = account.Get_AccountType().Get_Label();
                    }
                }
                foreach (Account account in FormMain.user.GetAccounts())
                {
                     if (account.Get_Id() == transfer.getAccountTo().Get_Id())
                     {
                         aToName = account.Get_AccountType().Get_Label();
                     }                    
                }
                foreach (Beneficiary beneficiary in FormMain.user.GetBeneficiary())
                {
                    if (beneficiary.getBeneficiaryId() == transfer.getBeneficiaryTo().getBeneficiaryId())
                    {
                        aToName = beneficiary.getBeneficiaryName();
                    }
                }
                DgvTransferHistory.Rows.Add(aFromName, aToName, transfer.getAmount() , transfer.getDate());

                

            }
            FormMain.dbConnexion.Close();
        }

    }
}
