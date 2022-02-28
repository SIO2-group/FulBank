using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FulBank;
using MySql.Data.MySqlClient;


namespace Fulbank.classes
{
    public class User : Person
    {
        private string _phone;
        private string _email;
        private string _landline;
        private string _address;
        private List<Account> _accounts;
        private List<Beneficiary> _beneficiaries;
        private List<Transfer> _transfers;
        private List<Cryptowallet> _wallets;

        public User(int id, string name, string firstname, string email, string phone, string homePhone, string address) : base(id, name, firstname)
        {
            Set_phone(phone);
            Set_email(email);
            Set_homePhone(homePhone);
            Set_address(address);
            _accounts = _accounts = new List<Account>();
            _beneficiaries = new List<Beneficiary>();
            _transfers = new List<Transfer>();
            _wallets = new List<Cryptowallet>();
        }

        public string Get_phone()
        {
            return _phone;
        }

        public void Set_phone(string value)
        {
            _phone = value;
        }

        public string Get_email()
        {
            return _email;
        }

        public void Set_email(string value)
        {
            _email = value;
        }


        public string Get_homePhone()
        {
            return _landline;
        }

        public void Set_homePhone(string value)
        {
            _landline = value;
        }


        public string Get_address()
        {
            return _address;
        }

        public void Set_address(string value)
        {
            _address = value;
        }

        public void Add_Account(int id, int type, double balance, int overdraftLimit)
        {
            _accounts.Add(new Account(id, balance, type, overdraftLimit));
        }

        public List<Account> GetAccounts()
        {
            return _accounts;
        }

        public Dictionary<string, Account> getAccountsDico()
        {
            Dictionary<string, Account> dico = new Dictionary<string, Account>();
            foreach(Account account in _accounts)
            {
                dico.Add(account.Get_AccountType().Get_Label(), account);
            }
            return dico;
        }
        public Dictionary<string, Cryptowallet> getWalletsDico()
        {
            Dictionary<string, Cryptowallet> dico = new Dictionary<string, Cryptowallet>();
            foreach (Cryptowallet wallet in _wallets)
            {
                dico.Add(wallet.GetSymbol(), wallet);
            }
            return dico;
        }

        public List<Beneficiary> GetBeneficiary()
        {
            return _beneficiaries;
        }


        public void Add_Beneficiary(int accountId, string name, int userId)
        {
            _beneficiaries.Add(new Beneficiary(accountId, name));
        }

        public void Insert_Beneficiary(int accountId, string name, int userId)
        {
            FormMain.dbConnexion.Open();
            string commandAddBeneficiary = "INSERT INTO beneficiary(B_USER_ID, B_ACCOUNT_ID, B_NAME) VALUES('" + userId + "','" + accountId + "','" + name + "' )";
            MySqlCommand cmdAddBeneficiary = new MySqlCommand(commandAddBeneficiary, FormMain.dbConnexion);
            cmdAddBeneficiary.ExecuteNonQuery();
            FormMain.dbConnexion.Close();
        }

        public void add_Transfer(double amount, DateTime date, Account AccountFrom, Account AccountTo)
        {
            _transfers.Add(new Transfer(amount, date, AccountFrom, AccountTo));
        }

        public void add_TransferToBeneficiary(double amount, DateTime date, Account AccountFrom, Account AccountTo, Beneficiary BeneficiaryTo)
        {
            _transfers.Add(new Transfer(amount, date, AccountFrom, AccountTo, BeneficiaryTo));
        }
        public List<Transfer> getTransfers()
        {
            return _transfers;
        }


        public void AddWallet(string symbol, float amount)
        {
            _wallets.Add(new Cryptowallet(symbol, amount));
        }

        public void UpdateWallet(string symbol, float amount)
        {
            string commandInsertWallet = "INSERT INTO `crypto_wallet`(`CW_UID`, `CW_C_SYMBOL`) VALUES ('"+ FormMain.user.Get_Id() +"', '" + symbol + "') ON DUPLICATE KEY UPDATE CW_AMOUNT = (CW_AMOUNT + '"+ amount +"')";
            MySqlCommand cmddInsertWallet = new MySqlCommand(commandInsertWallet, FormMain.dbConnexion);
            cmddInsertWallet.ExecuteNonQuery();
        }

        public List<Cryptowallet> GetWallets()
        {
            return _wallets;
        }
    }
}
