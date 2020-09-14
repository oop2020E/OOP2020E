using LibOOP;
using System;

namespace KG01_Opgaver
{
    class PersonPrinter
    {
        public void PrintPerson(Person p)
        {
            Console.WriteLine($"{p.Fornavn} {p.Efternavn}, {p.Alder}");
        }

        public void PrintTree(Person p)
        {
            if (p == null)
                return;
            PrintPerson(p);
            PrintTree(p.Far);
            PrintTree(p.Mor);
        }
    }
    class Person
    {
        private int _alder;
        private string _fornavn;
        private string _efternavn;

        #region Del3
        private static int idcounter = 0;
        private int _id = ++idcounter;
        public int Id
        {
            get { return _id; }
        }
        #endregion

        #region Del2
        public Person(int alder, string fornavn, string efternavn) : this(alder, fornavn, efternavn, null, null)
        {
        }
        public Person(int alder, string fornavn, string efternavn, Person far, Person mor)
        {
            Alder = alder;
            Fornavn = fornavn;
            Efternavn = efternavn;
            Far = far;
            Mor = mor;
        }
        #endregion

        public string Fornavn
        {
            get { return _fornavn; }
            set
            {
                if(string.IsNullOrEmpty(value)) // eksempel med null or empty
                    throw new ArgumentException($"{nameof(Fornavn)} cannot be null or empty"); // eksempel med nameof og string-interpolation
                _fornavn = value;
            }
        }

        public string Efternavn
        {
            get { return _efternavn; }
            set
            {
                if(value==null) 
                    throw new ArgumentNullException($"{nameof(Efternavn)} cannot be null");
                _efternavn = value;
            }
        }

        public int Alder
        {
            get { return _alder; }
            set
            {
                if (value < 0) 
                    throw new ArgumentOutOfRangeException("Alder should be greater than or equal to zero"); // bemærk, navnet Alder bliver ikke synkroniseret med medlemmet
                _alder = value;
            }
        }

        public Person Far { get; set; } 
        public Person Mor { get; set; }
    }

    public class KG01_løsning : IOpgaveløsning
    {
        public void Run()
        {
            Person mig = new Person(20, "Thomas", "Thomasson", 
                new Person(60, "Farmand", "Farsen", 
                    new Person(100, "Farfar", "farfarsen"), 
                    new Person(100, "Farmor", "Farmorsen") 
                    ), 
                new Person(60, "Mor", "Morsen",
                    new Person(100, "Morfar", "Morfarsen"),
                    new Person(100, "Mormor", "Mormorsen")
                    )
                );
            PersonPrinter pp = new PersonPrinter();
            pp.PrintTree(mig);
        }
    }
}
