using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using FigureSample;
using KG01Exercises;
using LiveCode;


namespace OOP2020
{
    class C
    {
        public void A()
        {
            B();
        }

        private void B()
        {
            try
            {
                D();
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        private void D()
        {
            E();
            Console.WriteLine("Resten af D");
        }

        private void E()
        {
            throw new NotImplementedException("Not implemented yet");
            Console.WriteLine("Resten af E");
        }
    }

    class Program
    {

        public static  void WriteZeroToStream(Stream s)
        {
            s.Write(new byte[]{0}, 0, 1);
        }

        static void WriteZErotoFile(string filename)
        {

            FileStream mystream = null;
            try
            {
                mystream = File.OpenWrite(filename);
                WriteZeroToStream(mystream);
                WriteZeroToStream(mystream);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                throw new MyCustomException("",e);
            }
                finally
            {
                mystream.Close();
            }
        }

        static void Main()
        {
            var v= (new C());
            try
            {
                v.A();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            try
            {
                string fname = Console.ReadLine();
                WriteZErotoFile(fname);

            }
            catch (IOException e) 
            {
                Console.WriteLine(e);
            }
            


            //int u;
            //while (!int.TryParse(Console.ReadLine(), out u))
            //{
            //    Console.WriteLine("Not a number");
            //}




            //new C().A();
            ////CircleProgram cp = new CircleProgram();
            ////cp.Run();
            ////KG01ExerciseSolution løsning = new KG01ExerciseSolution();
            ////løsning.Run();
            ////new Demo().Run();
            //try
            //{
            //    int.TryParse("10", out int k);

            //    Person p = new Person();
            //    p.Name = "";
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine("Det var ikke et tal");
            //}
            //catch (ArgumentException e)
            //{

            //}
            //catch (Exception e)
            //{

            //}
        }
    }

    internal class MyCustomException : Exception
    {
        public MyCustomException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
