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
            this.accountType = new AccountType(0, "0", 0, 0);
        }
    }
}
