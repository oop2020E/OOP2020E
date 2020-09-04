using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KG01_intro
{
    class Basics
    {
        public int tal;
        public static int stal;
        public void Run()
        {
            
            //_INTROTODO 05 Intro til syntax og miljø
            #region Syntax og miljø
            /* kommer løbende 
             * -- programmet køres med en af følgende:
             *      F5,
             *      den playknappen øverst, eller 
             *      under Debug-menuen (Start Debugging)
             *      
             */
            #endregion

            #region Variabler og typer

            #region Taltyper
            //_INTROTODO 10 TAL
            int k = 10;
            decimal f = 0.0m;
            double d = 10.0;
            decimal m = 10m;

            #region Talpræcision
            //for (int i = 0; i < 10000000; i++)
            //{
            //    f += 0.1m;
            //}
            Console.WriteLine(f);
            #endregion
            #endregion

            #region Andre typer

            bool b1 = true;
            bool b2 = false;
            char v = '\n';
            string s = "Thomas";
            s = s + s;
            Console.WriteLine(s.ToLower());
            // short, byte
            #endregion

            #region Arrays
            int[] array = new int[10];
            
            int[][] jagged = new int[5][];

            int[,] multidim = new int[10, 10];
            #endregion

            #endregion

            #region Kontrolstrukturer og metoder

            #region Metoder og selektive

            Console.WriteLine(Fib1(10));
            //Console.WriteLine(Fib2(10));
            #endregion

            #region iterative
            int[] tal = new int[]{ 1, 2, 4, 5, 6, 7, 8, 9 };
            
            for (int i = 0; i < tal.Length; i++)
            {

            }


            while (true)
            {
                //Console.WriteLine("Uendeligt loop? -- vi bruger break");
                break;
            }


            foreach (int item in tal)
            {
                Console.WriteLine(item);
            }

            #endregion

            #endregion

        }

        /// <summary>
        /// Fibonacci med ifsætning
        /// </summary>
        /// <param name="n">Tal i fibonaccirækken</param>
        /// <returns></returns>
        private int Fib1(int n)
        {
            //if (n < 0)
            //    throw new ArgumentOutOfRangeException();

            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
                return 1;
            return Fib1(n - 1) + Fib1(n - 2);
        }

        /// <summary>
        /// Fibonacci med switch
        /// </summary>
        /// <param name="n">Tal i fibonaccirækken</param>
        /// <returns></returns>
        ////private int Fib2(int n)
        //{
        //    //if (n < 0)
        //    //    throw new ArgumentOutOfRangeException();

        //    switch (n)
        //    {
        //        case 0:
        //            return 0;
        //        case 1:
        //            return 1;
        //            break;
        //        case 2:
        //            Console.WriteLine("du skrevet 2");
        //            break;
        //        default:
        //            return Fib2(n - 1) + Fib2(n - 2);
        //    }
        //}

    }
}
