using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.classes
{
    class User : Person
    {
        private string phone;
        private string email;
        private string home_phone;
        private string adress;
        private List<Account> listeComptes = new List<Account>();

        public User(string phone, string email, string home_phone, string adress, int id, string name, string password):base(id ,name, password)
        {
            this.phone = phone;
            this.email = email;
            this.home_phone = home_phone;
            this.adress = adress;
        }
    }
}
