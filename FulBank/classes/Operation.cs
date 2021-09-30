namespace Fulbank.classes
{
    class Operation
    {
        private int _id;
        private double _amount;
        private bool _debit;
        private User _user;
        private Account _account;
        private Terminal _terminalUsed;

        public Operation(
            int id, double amount, bool debit, 
            User user, Account account, Terminal terminalUsed
            )
        {
            _id = id;
            _amount = amount;
            _debit = debit;
            _user = user;
            _account = account;
            _terminalUsed = terminalUsed;
        }
    }
}
