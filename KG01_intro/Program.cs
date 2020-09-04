using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KG01_intro.Circle
{
    //INTROTODO 15 Discuss memory
    //INTROTODO 20 Create class: fields, accessmodifiers -- printer-driver
    //INTROTODO 30 Indkapsling -- fra GetV/SetV() til Properties

    //TODOEXTRA 50 Enum+switch
    class Person
    {

    }


    class Program
    {
        static void Main(string[] args)
        {
            Basics b = new Basics();
            b.tal = 10;
            
            Basics b2;
           
            b2 = b;
            b2.tal = 1;
            int k = 10;
            int kb = k;
            k = 1;
            b.Run();
            //Person p = new Person();


            //int i;
            //var k = 1L;
            //long l = 10;
            //l = k;
            //k = (int)l;
        }
    }
}
