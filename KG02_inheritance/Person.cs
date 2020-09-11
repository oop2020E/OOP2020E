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
}
