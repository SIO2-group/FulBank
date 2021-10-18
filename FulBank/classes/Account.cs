using System.Collections.Generic;
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


    }
}
