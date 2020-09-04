using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KG01_intro.Circle
{
    //_INTROTODO 15 Discuss memory
    //INTROTODO 20 Create class: fields, accessmodifiers -- printer-driver
    //INTROTODO 30 Indkapsling -- fra GetV/SetV() til Properties

    //TODOEXTRA 50 Enum+switch
    class Document
    {
        public int Linier;
    }

    class Printer
    {

        private string _navn;
         public string Navn
        {
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                _navn = value;
            }
            private get
            {
                return _navn;
            }
        }

        private string GetNavn()
        {
            return Navn;
        }

        public void Print(Document text)
        {
            for(int i = 0; i < text.Linier; i++)
            {
                //Console.WriteLine();
                Drej(1);
            }
        }
        private void Drej(int linier)
        {
            // ...
        }

        public int MyProperty { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(args.Length);
            
            Printer printer = new Printer();
            printer.Navn = "Ole";
            printer.Navn = null;
            printer.Print(new Document());
            
        }
    }
}
