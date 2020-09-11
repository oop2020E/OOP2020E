using System;

namespace KG02_inheritance
{

    public class Person
    {
        public string Efternavn
        {
            get
            {
                return _efternavn;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                _efternavn = value;
            }
        }


        public void SetFornavn(string value)
        {
            if (value == null)
                throw new ArgumentNullException();
            _fornavn = value;
        }
        private string _fornavn;
        private string _efternavn;

        public string GetName()
        {
            return _fornavn;
        }
    }

    public class Demo
    {
        public void Run()
        {


        }
        //TODO 001 Repeat and demonstrate last week's material - Figure

        //TODO 010 Repeat: C#: statically typed and strongly typed language -- primitive types and custom types

        //TODO 020 Inheritance hierarchies and type compatibility 

        //TODO 030 virtual, override

        //TODO 040 abstract

        //TODO 050 System.Object

        //TODO 060 statisk polymorfi

        //TODO 070 dynamisk polymorfi

        //TODO 080 access modifiers
    }
}
