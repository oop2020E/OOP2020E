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
        public void Print(Document text)
        {
            for(int i = 0; i < text.Linier; i++)
            {
                //Console.WriteLine();
                Drej(1);
            }
        }
        public void Drej(int linier)
        {
            // ...
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print(new Document());
            printer.Drej(1);
        }
    }
}
