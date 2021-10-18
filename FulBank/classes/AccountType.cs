namespace Fulbank.classes
{
    class AccountType
    {
        private int _id;
        private string _label;
        private double _interest;
        private int _ceil;

        public AccountType(int id, string label, double interest, int ceil)
        {
            _id = id;
            _label = label;
            _interest = interest;
            _ceil = ceil;
        }

    }
}
