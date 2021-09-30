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

    }
}
