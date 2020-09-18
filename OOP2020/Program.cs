using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FigureSample;
using KG01Exercises;
using LibOOP;


namespace OOP2020
{

    class Person :IComparable
    {
        public string Efternavn { get; set; }
        public string Navn { get; set; }
        public int CompareTo(object obj)
        {
            Person other = (Person) obj;
            return -1*this.Navn.CompareTo(other.Navn);
        }
    }

    class Efternavnssoteringsting : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return -1*x.Efternavn.CompareTo(y.Efternavn);
        }
    }

    class FooComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x.ToString().Length.CompareTo(y.ToString().Length);
        }
    }

    class Program
    {
        static void Main()
        {
            Person p = new Person()
            {
                Navn = "thomas",Efternavn = "Bøgholm"
            };
            List<Person> pl = new List<Person>(){
                p, 
                new Person(){Navn = "Ole",Efternavn = "Anders"},
                new Person(){Navn = "Anders", Efternavn = "And"}
            };

            pl.Sort(new Efternavnssoteringsting());
            foreach (var person in pl)
            {
                Console.WriteLine(person.Efternavn);
            }

            List<int> l;
            l = new List<int>();
            l.Add(40);
            l.Add(30);
            l.Add(60);
            l.Add(11);
            l.Sort();
            foreach (int i in l)
            {
                Console.WriteLine(i);
            }


            //CircleProgram cp = new CircleProgram();
            //cp.Run();
            IExerciseSolution løsning = new KG01ExerciseSolution();
            //løsning.Run();

        }
    }
}
