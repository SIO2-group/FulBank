using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Fulbank.classes
{

    public class Beneficiary
    {
        private int _accountId;
        private string _name;

        public Beneficiary(int accoutId, string name)
        {
            _accountId = accoutId;
            _name = name;
        }

        public string getBeneficiaryName()
        {
            return _name;
        }

        public int getBeneficiaryId()
        {
            return _accountId;
        }
    }
}
