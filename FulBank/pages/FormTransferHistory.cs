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
            FormMain.dbConnexion.Open();
            string commandTextSelectTransfer = @"SELECT T_ID_ACCOUNT_FROM, T_ID_ACCOUNT_TO, T_AMOUNT, DATE_FORMAT(T_DATE,'%d-%m-%Y') as T_DATE
                                                FROM transaction
                                                WHERE T_ID_ACCOUNT_FROM IN(SELECT A_ID
                                                                            FROM account
                                                                            WHERE A_ID_USER = '" + FormMain.user.Get_Id() + "')";
            MySqlCommand cmdSelectTransfer = new MySqlCommand(commandTextSelectTransfer, FormMain.dbConnexion);
            MySqlDataReader transfers = cmdSelectTransfer.ExecuteReader();

            while (transfers.Read())
            {
                string aFromName = "Erreur";
                string aToName = "Erreur";
                foreach(Account account in FormMain.user.GetAccounts())
                {
                    if (account.Get_Id() == int.Parse(transfers["T_ID_ACCOUNT_FROM"].ToString()))
                    {
                        aFromName = account.Get_AccountType().Get_Label();
                    }
                }
                foreach (Account account in FormMain.user.GetAccounts())
                {
                    if (account.Get_Id() == int.Parse(transfers["T_ID_ACCOUNT_TO"].ToString()))
                    {
                        aToName = account.Get_AccountType().Get_Label();
                    }
                }
                foreach (Beneficiary beneficiary in FormMain.user.GetBeneficiary())
                {
                    if (beneficiary.getBeneficiaryId() == int.Parse(transfers["T_ID_ACCOUNT_TO"].ToString()))
                    {
                        aToName = beneficiary.getBeneficiaryName();
                    }
                }
                dgvTransferHistory.Rows.Add(aFromName, aToName, transfers["T_AMOUNT"].ToString() , transfers["T_DATE"].ToString());

                

            }
            FormMain.dbConnexion.Close();
        }
    }
}
