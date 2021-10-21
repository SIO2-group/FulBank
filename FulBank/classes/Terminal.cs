using System;
namespace Fulbank.classes
{
    public class Terminal
    {
        private int _id;
        private string _name;
        private string _city;
        private string _ip;
        public static Terminal name;

        public Terminal(int id, string name, string city, string ip)
        {
            _id = id;
            _name = name;
            _city = city;
            _ip = ip;
            
        }
        
    }

}
