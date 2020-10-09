using System;
using System.Collections.Generic;
using System.IO;

namespace LiveCode
{
    class Person : IComparable<Person>
    {
        public string NAvn { get; set; }

        public int CompareTo(Person other)
        {
            return NAvn.CompareTo(other.NAvn);
        }
    }

    public class Demo 
    {
        public void Run()
        {
            TreeNode<int> inttree = new TreeNode<int>();
            TreeNode<string> strTree = new TreeNode<string>();

            string[] sarr = new string[10];
            int[] intarr = new int[10];
            Methods methods = new Methods();
            methods.Init(sarr, "");
            methods.Init(intarr, 5);


            List<Person> ps = new List<Person>();
            ps.Add(new Person() { NAvn = "Thomas" });
            Person max = methods.Max(ps);

            Pair<List<int>, List<string>> v;

           // IComparable<char> maxchar = methods.Max<IComparable<char>>((IEnumerable<IComparable<char>>)(new List<IComparable<char>> { 'a', 'b', 'c' }));
        }
    }
}