using System;

namespace Fulbank.classes
    
{
    ///<summary>Class Operation contains the operation's data (id, amount, debit, date, terminalid)
    ///</summary>
    public class Operation
    {
        private int _id;
        private double _amount;
        private bool _debit;
        private DateTime _date;
        private Terminal _terminalUsed;

        ///<summary>Public Operation is the constructor of the Operation class
        ///</summary>
        public Operation( int id, double amount, bool debit, DateTime date )
        {
            _id = id;
            _amount = amount;
            _debit = debit;
            _date = date;
        }

        public Operation(int id, double amount, bool debit)
        {
            _id = id;
            _amount = amount;
            _debit = debit;
            _date = new DateTime();
        }

        public double Get_amount()
        {
            return _amount;
        }
        public bool Get_debit()
        {
            return _debit;
        }
        public DateTime Get_date()
        {
            return _date;
        }
    }
}
