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

    class Figur
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Cirkel : Figur
    {
        public int Radius { get; set; }
        public int Area()
        {
            return (int)(Math.PI * Radius * Radius);
        }
    }

    class Rectangle : Figur
    {
        public int Area()
        {
            return H * B;
        }
        public int H { get; set; }
        public int B { get; set; }
    }



    public class Demo
    {
        public void Run()
        {
            Cirkel c = new Cirkel();
            
        }
        //TODO_ 001 Repeat and demonstrate last week's material - Figure

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
