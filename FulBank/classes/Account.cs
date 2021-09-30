using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.classes
{
    class Account
    {
        private int id;
        private float balance;
        private string rib;
        private string name;
        private AccountType accountType;

        public Account(int id, float balance, string rib, string name, string type)
        {
            this.id = id;
            this.balance = balance;
            this.rib = rib;
            this.name = name;
            switch (type)
            {
                case "A": this.accountType = new AccountType(1, "Livret A", 0.25, 22950);
                    break;
                case "Cheque":
                    this.accountType = new AccountType(2, "Compte chèque", 0, 1000000000);
                    break;
            }
        }
    }
}
