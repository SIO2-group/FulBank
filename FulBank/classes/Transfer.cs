namespace Fulbank.classes
{
    class Transfer
    {
        private int _id;
        private double _amount;
        private Account _accountFrom;
        private Account _accountTo;

        public Transfer(int id, double amount, Account accountFrom, Account accountTo)
        {
            _id = id;
            _amount = amount;
            _accountFrom = accountFrom;
            _accountTo = accountTo;
        }
    }
}
