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

        public User(int id, string name, string firstname, string email, string phone, string homePhone, string address) : base(id, name, firstname)
        {
            Set_phone(phone);
            Set_email(email);
            Set_homePhone(homePhone);
            Set_address(address);
            _accounts = _accounts = new List<Account>();
            _beneficiaries = new List<Beneficiary>();
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
        public List<Beneficiary> GetBeneficiary()
        {
            return _beneficiaries;
        }

        public void Add_Beneficiary(int accountId, string name, int userId)
        {
            _beneficiaries.Add(new Beneficiary(accountId, name));
        }

    }
}
