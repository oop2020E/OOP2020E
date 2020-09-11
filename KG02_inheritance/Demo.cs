﻿namespace KG02_inheritance
{
    public class Demo
    {
        public void Run()
        {
            Cirkel c = new Cirkel(10);
            Figur f = c;

            //Cirkel c = new Cirkel(1);

            System.Console.WriteLine(((Cirkel)f).Area());

            PrintArea(new Rectangle());
            PrintArea(f);
        }


        public void PrintArea(Figur f)
        {
            System.Console.WriteLine(f.Area());
        }


        //TODO_ 001 Repeat and demonstrate last week's material - Figure

        //TODO 010 Repeat: C#: statically typed and strongly typed language -- primitive types and custom types

        //TODO 020 Inheritance hierarchies and type compatibility 

        //TODO 030 virtual, override

        //TODO 040 abstract

        //TODO 050 System.Object

        //TODO 060 statisk polymorfi

        //TODO 070 dynamisk polymorfi

        //TODO 080 access modifiers
    }
}
