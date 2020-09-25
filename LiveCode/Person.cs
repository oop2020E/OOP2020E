using System;
using System.Collections.Generic;

namespace LiveCode
{
    public class Person
    {
        private int sortmethod;
        private string _name;
        private string _lastname;

        public Person()
        {
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if(string.IsNullOrEmpty(value))
                    throw  new NameFormatException(value);
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