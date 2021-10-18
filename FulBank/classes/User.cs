using System.Collections.Generic;

namespace Fulbank.classes
{
    class User : Person
    {
        private string _phone;
        private string _email;
        private string _homePhone;
        private string _address;
        private List<Account> _accounts = new List<Account>();

        public User(
            string phone, string email, string homePhone, 
            string address, int id, string name, string password
            ):base(id ,name, password)
        {
            _phone = phone;
            _email = email;
            _homePhone = homePhone;
            _address = address;
        }
    }
}
