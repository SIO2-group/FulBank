using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Fulbank.classes
{

    public class Beneficiary
    {
        private int _accoutId;
        private string _name;

        public Beneficiary(int accoutId, string name)
        {
            _accoutId = accoutId;
            _name = name;
        }

        public string getBeneficiaryName()
        {
            return _name;
        }
    }
}
