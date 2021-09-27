using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.classes
{
    class AccountType
    {
        private int id;
        private string label;
        private double interest;
        private int ceil;

        public AccountType(int id, string label, double interest, int ceil)
        {
            this.id = id;
            this.label = label;
            this.interest = interest;
            this.ceil = ceil;
        }

  /*      public AccountType getAccountType(string type)
        {
            AccountType ReturnedType = new AccountType(0, "0", 0.00, 0); ;
            switch (type)
            {
                case "A" : ReturnedType = new AccountType(0, "livret A", 0.50, 22950);
                    break;
            }

            return ReturnedType;
        } */
    }
}
