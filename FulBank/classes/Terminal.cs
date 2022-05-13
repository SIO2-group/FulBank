using System;
namespace Fulbank.classes
{
    public class Terminal
    {        
        private string _id;
        private string _address;


        public Terminal(string id,string address)
        {
            _id = id;
            _address = address;
        }


        internal string getId()
        {
            return _id;
        }

        public string getAddress()
        {
            return _address;
        }

    }

}
