using System;

namespace LiveCode
{
    class Person
    {
        private string _name;
        private string _lastname;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
    }
}