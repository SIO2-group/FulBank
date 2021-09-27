using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.classes
{
    class Transfer
    {
        private int id;
        private double amount;
        private Account accountFrom;
        private Account accountTo;

        public Transfer(int id, double amount, Account accountFrom, Account accountTo)
        {
            this.id = id;
            this.amount = amount;
            this.accountFrom = accountFrom;
            this.accountTo = accountTo;
        }
    }
}
