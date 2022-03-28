using System.Collections.Generic;
using System.Windows.Forms;
using FulBank;
using MySql.Data.MySqlClient;

namespace Fulbank.classes
{
    ///<summary>Class Beneficiary contains the beneficiary's data (id, name)
    ///</summary>
    public class Beneficiary
    {
        private int _accountId;
        private string _name;

        ///<summary>Public Beneficiary is the constructor of the Beneficiary class
        ///</summary>
        public Beneficiary(int accoutId, string name)
        {
            _accountId = accoutId;
            _name = name;
        }

        public Beneficiary()
        {
            _accountId = -1;
        }

        public string getBeneficiaryName()
        {
            return _name;
        }

        public int getBeneficiaryId()
        {
            return _accountId;
        }

        public void Credit(double creditAmount)
        {
            FormMain.dbConnexion.Open();
            string commandTextCredit = @"UPDATE account SET A_BALANCE = A_BALANCE + " + creditAmount + " WHERE A_ID = " + this.getBeneficiaryId() + "";
            MySqlCommand cmdCredit = new MySqlCommand(commandTextCredit, FormMain.dbConnexion);
            cmdCredit.ExecuteNonQuery();
            FormMain.dbConnexion.Close();
            MessageBox.Show("Crédit vers le bénéficiaire effectué");
        }
        public bool isCreditable(double creditAmount)
        {
            FormMain.dbConnexion.Open();
            bool result = false;
            string commandTextIsCreditable = @"SELECT (account.A_BALANCE + '" + creditAmount + "') as 'BALANCE_AFTER_CREDIT', AT_LIMIT FROM account INNER JOIN account_type ON account.A_ID_ACCOUNTTYPE = account_type.AT_ID    WHERE account.A_ID = '" + this.getBeneficiaryId() + "'";
            MySqlCommand cmdIsCreditable = new MySqlCommand(commandTextIsCreditable, FormMain.dbConnexion);
            MySqlDataReader beneficiaryIsCreditable = cmdIsCreditable.ExecuteReader();
            while (beneficiaryIsCreditable.Read())
            {
                if (double.Parse(beneficiaryIsCreditable["BALANCE_AFTER_CREDIT"].ToString()) < int.Parse(beneficiaryIsCreditable["AT_LIMIT"].ToString()))
                {
                    result = true;
                }
                else
                {
                    MessageBox.Show("Plafond du bénéficiaire atteind");
                }
            }
            FormMain.dbConnexion.Close();
            return result;
        }
    }
}
