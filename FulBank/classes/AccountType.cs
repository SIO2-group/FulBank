namespace Fulbank.classes
{
    ///<summary>Class AccountType contains the accounttype's data (id, label, interest and cell)
    ///the class stores the different existing account type, operation and transfers related to the account
    ///</summary>
    public class AccountType
    {
        private int _id;
        private string _label;
        private double _interest;
        public int _limit;

        ///<summary>Public AccountType is the constructor of the AccountType class
        ///</summary>
        public AccountType(int id, string label, double interest, int ceil)
        {
            _id = id;
            _label = label;
            _interest = interest;
            _limit = ceil;
        }

        public int Get_Id()
        {
            return _id;
        }

        public string Get_Label()
        {
            return _label;
        }

        public double Get_Interest()
        {
            return _interest;
        }

        public int Get_Limit()
        {
            return _limit;
        }




    }
}
