using System;

namespace KG01Exercises
{
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
}