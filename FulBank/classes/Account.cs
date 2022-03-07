using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FulBank;

using MySql.Data.MySqlClient;

namespace Fulbank.classes
{
    public class Account
    {
        private int _id;
        private double _balance;
        private AccountType _accountType;
        private List<Transfer> _transfer;
        private List<Operation> _operations;
        private int _overdraftLimit;

        public Account(int id, double balance, int type, int overdraftLimit)
        {
            string dsnConnexion = "server=localhost;database=fulbank;uid=root;password='';SSL MODE='None'"; //préparation pour la connection à la bdd
            MySqlConnection dbConnexion = new MySqlConnection(dsnConnexion);
            dbConnexion.Open();
            string commandGetAccountType = "SELECT * FROM account_type WHERE AT_ID = '" + type + "'";
            MySqlCommand cmdGetAccountType = new MySqlCommand(commandGetAccountType, dbConnexion);
            MySqlDataReader userAccounts = cmdGetAccountType.ExecuteReader();

            _id = id;
            _balance = balance;
            userAccounts.Read();
            _accountType = new AccountType(int.Parse(userAccounts["AT_ID"].ToString()), userAccounts["AT_NAME"].ToString(), double.Parse(userAccounts["AT_INTEREST"].ToString()), int.Parse(userAccounts["AT_LIMIT"].ToString()));
            _overdraftLimit = overdraftLimit;
            dbConnexion.Close();
            _transfer = new List<Transfer>();
            _operations = new List<Operation>();
        }

        public Account()
        {
               _id = -1;
        }

        public int Get_Id()
        {
            return _id;
        }
        public double Get_Balance()
        {
            return _balance;
        }
        public AccountType Get_AccountType()
        {
            return _accountType;
        }
        public int Get_Limit()
        {
            return _overdraftLimit;
        }

        public void Debit(double value)
        {
            FormMain.dbConnexion.Open();
            string commandTextCredit = @"UPDATE account SET A_BALANCE = A_BALANCE - "+ value.ToString().Replace(",",".") + " WHERE A_ID = " + this.Get_Id() + "";
            MySqlCommand cmdCredit = new MySqlCommand(commandTextCredit, FormMain.dbConnexion);
            cmdCredit.ExecuteNonQuery();
            FormMain.dbConnexion.Close();
        }

        public void OperationDeposit(double value)
        {
            _balance += value;
        }

        public void OperationDebit(double value)
        {
            _balance -= value;
        }


        public void CryptoSell(string amount)
        {
            _balance = _balance + double.Parse(amount);
            amount = amount.Replace(",", ".");

            FormMain.dbConnexion.Open();
            string commandTextCredit = @"UPDATE account SET A_BALANCE = A_BALANCE + " + amount + " WHERE A_ID = " + this.Get_Id() + "";
            MySqlCommand cmdCredit = new MySqlCommand(commandTextCredit, FormMain.dbConnexion);
            cmdCredit.ExecuteNonQuery();
            FormMain.dbConnexion.Close();
        }

        public void CryptoBuy(string amount)
        {
            _balance = _balance - double.Parse(amount);
            amount = amount.Replace(",", ".");

            FormMain.dbConnexion.Open();
            string commandTextCredit = @"UPDATE account SET A_BALANCE = A_BALANCE - " + amount + " WHERE A_ID = " + this.Get_Id() + "";
            MySqlCommand cmdCredit = new MySqlCommand(commandTextCredit, FormMain.dbConnexion);
            cmdCredit.ExecuteNonQuery();
            FormMain.dbConnexion.Close();

        }

        public void Credit(double creditAmount)
        {
            FormMain.dbConnexion.Open();
            string commandTextCredit = @"UPDATE account SET A_BALANCE = A_BALANCE + " + creditAmount + " WHERE A_ID = " + this.Get_Id() +"";
            MySqlCommand cmdCredit = new MySqlCommand(commandTextCredit, FormMain.dbConnexion);
            cmdCredit.ExecuteNonQuery();
            FormMain.dbConnexion.Close();
            MessageBox.Show("Crédit vers le bénéficiaire effectué");
        }

        public bool isCreditable(double creditAmount)
        {
            bool result = false;
                if ((this.Get_Balance() + creditAmount) < this.Get_AccountType().Get_Limit())
                {
                    result = true;
                }
                else
                {
                    MessageBox.Show("Plafond du compte cible");
                }
            return result;
        }

        public void Add_Operation(int id, double amount, bool debit, DateTime date)
        {
            _operations.Add(new Operation(id, amount, debit, date));
        }

        public List<Operation> getOperation()
        {
            return _operations;
        }

    }
}
