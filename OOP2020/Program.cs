using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FigureSample;
using KG01Exercises;
using LiveCode;
using NSubstitute;

namespace OOP2020
{



    class Program
    {


        static void Main()
        {
            IFoo foo = Substitute.For<IFoo>();

            foo.Add(2, 2).Returns(19);

            Console.WriteLine(foo.Add(1,2));

            //List<string> l = new List<string> { "THomas", "Jenes" };

            //foreach (var item in l)
            //{
            //    PrintChars(item);
            //}


            //CircleProgram cp = new CircleProgram();
            //cp.Run();
            //KG01ExerciseSolution løsning = new KG01ExerciseSolution();
            //løsning.Run();
            //new Demo().Run();
        }

        private static void PrintChars(string item)
        {
            foreach (var ch in item)
            {
                Console.WriteLine(ch);
            }
        }
    }
}
