using System;
namespace Fulbank.classes
{
    public class Terminal
    {
        private string _building;
        private string _city;
        private string _ip;

        public Terminal(string city, string building,  string ip)
        {
            _building = building;
            _city = city;
            _ip = ip;
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


    }

}
