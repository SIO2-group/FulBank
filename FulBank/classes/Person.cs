namespace Fulbank
{
    abstract class Person
    {
        private int _id;
        private string _name;
        private string _password;

        public Person(int id, string name, string password)
        {
            _id = id;
            _name = name;
            _password = password;
        }

    }
}
