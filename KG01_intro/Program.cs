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

        public string _navn;
         public string Navn
        {
            set
            {
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
    }


    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.SetNavn("Ole");
            Console.WriteLine("min printer hedder: " + printer.GetNavn());
            
            printer.Print(new Document());
            
        }
    }
}
