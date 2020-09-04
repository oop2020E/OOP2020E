using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KG01_intro
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
            Person p = new Person();
            Person* p = (Person*)malloc(sizeof(Person));
            free p;
            int i;
            var k = 1L;
            long l = 10;
            l = k;
            k = (int)l;
        }
    }
}
