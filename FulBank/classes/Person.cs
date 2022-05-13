namespace Fulbank
{
    ///<summary>Class Person contains the person's data (id, name, firstname)
    ///</summary>
    public abstract class Person
    {
        private int _id;
        private string _name;
        private string _firstname;

        ///<summary>Public Person is the constructor of the Person class
        ///</summary>
        public Person(int id, string name, string firstname)
        {
            _id = id;
            _name = name;
            _firstname = firstname;
        }

        public int Get_Id()
        {
            return _id;
        }
        public string Get_Name()
        {
            return _name;
        }
        public string Get_Firstname()
        {
            return _firstname;
        }

    }
}
