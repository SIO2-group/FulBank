namespace Fulbank.classes
{
    class Transfer
    {
        private int _id;
        private double _amount;
        private Account _accountFrom;
        private Account _accountTo;
        private Terminal _terminalUsed;

        public Transfer(int id, double amount, Account accountFrom, Account accountTo, Terminal aTerminal)
        {
            _id = id;
            _amount = amount;
            _accountFrom = accountFrom;
            _accountTo = accountTo;
            _terminalUsed = aTerminal;
        }
    }
}
