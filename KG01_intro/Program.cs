using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KG01_intro.Circle
{
    //_INTROTODO 15 Discuss memory
    //INTROTODO 20 Create class: fields, accessmodifiers -- printer-driver
    //INTROTODO 30 Indkapsling -- fra GetV/SetV() til Properties

    //TODOEXTRA 50 Enum+switch
    class Printer
    {
        public void Print()
        {

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();

            printer.Print("Hej");
        }
    }
}
