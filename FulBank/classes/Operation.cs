using System;

namespace Fulbank.classes
    
{
    public class Operation
    {
        private int _id;
        private double _amount;
        private bool _debit;
        private DateTime _date;
        private Terminal _terminalUsed;

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
