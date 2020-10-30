using System;

namespace KundeDb
{
    public class Kunde
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Bad format", nameof(Name));
                name = value;
            }
        }


    }


}
