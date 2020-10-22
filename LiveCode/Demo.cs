using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace LiveCode
{
        public class Demo 
    {

        public List<int> PlusZip(List<int> la, List<int> lb)
        {
            Debug.Assert(la.Count == lb.Count); // assume same length lists

            List<int> result = new List<int>();

            for (int i = 0; i < la.Count; i++)
            {
                result.Add(la[i] + lb[i]);
            }
            return result;
        }

        public List<int> MinusZip(List<int> la, List<int> lb)
        {
            Debug.Assert(la.Count == lb.Count); // assume same length lists

            List<int> result = new List<int>();

            for (int i = 0; i < la.Count; i++)
            {
                result.Add(la[i] - lb[i]);
            }
            return result;
        }



        #region Delegates
        public delegate int IntDelegate(int a, int b);

        int Plus(int v1, int v2)
        {
            return v1 + v2;
        }
        int Minus(int v1, int v2)
        {
            return v1 - v2;
        }

        public List<int> Zip(List<int> la, List<int> lb, IntDelegate f)
        {
            Debug.Assert(la.Count == lb.Count); // assume same length lists

            List<int> result = new List<int>();

            for (int i = 0; i < la.Count; i++)
            {
                result.Add(f(la[i], lb[i]));
            }
            return result;
        }

        #endregion

        public void Run()
        {
            List<int> n1 = new List<int> { 1, 2, 3, 4 };
            List<int> n2 = new List<int> { 2, 3, 4, 5 };


            List<int> result = MinusZip(n1, n2);



            PrettyPrintList(result);
        }

        public void PrettyPrintList<T>(List<T> l)
        {
            Console.WriteLine($"[{string.Join(",",l)}]");
        }
    }
}