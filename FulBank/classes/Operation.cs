using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.classes
{
    class Operation
    {
        private int id;
        private double amount;
        private bool debit;
        private User user;
        private Account account;
        private Terminal terminalUsed;

        public Operation(int id, double amount, bool debit, User user, Account account, Terminal terminalUsed)
        {
            this.id = id;
            this.amount = amount;
            this.debit = debit;
            this.user = user;
            this.account = account;
            this.terminalUsed = terminalUsed;
        }
    }
}
