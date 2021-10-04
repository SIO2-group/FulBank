namespace Fulbank.classes
{
    class Account
    {
        private int _id;
        private float _balance;
        private string _rib;
        private string _name;
        private AccountType _accountType;

        public Account(int id, float balance, string rib, string name, string type)
        {
            _id = id;
            _balance = balance;
            _rib = rib;
            _name = name;
            
            switch (type)
            {
                case "A": _accountType = new AccountType(1, "Livret A", 0.25, 22950);
                    break;
                case "Cheque":
                    _accountType = new AccountType(2, "Compte chèque", 0, 1000000000);
                    break;
            }
        }
    }
}
