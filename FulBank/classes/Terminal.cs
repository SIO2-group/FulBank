using System;
namespace Fulbank.classes
{
    public class Terminal
    {        
        private string _id;
        private string _building;
        private string _city;
        private string _ip;
        private string _cp;


        public Terminal(string id,string city, string building,  string ip, string cp)
        {
            _id = id;
            _building = building;
            _city = city;
            _ip = ip;
            _cp = cp;
        }

        public string getBuilding()
        {
            return _building;
        }
        public string getCity()
        {
            return _city;
        }
        public string getIp()
        {
            return _ip;
        }

        internal string getId()
        {
            return _id;
        }

        public string getCP()
        {
            return _cp;
        }

    }

}
