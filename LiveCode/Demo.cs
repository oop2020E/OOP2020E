using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace LiveCode
{

    //• concepts and concept formation in object-oriented programming
    //• classes, methods, interfaces, abstract classes and generic variants
    class Person
    {
        public string Navn { get; set; }
        public Person Far { get; }
        public Person person { get; }
    }

    interface IPair<TFst, TSnd>
    {

    }
    class Pair<TFst, TSnd> : IPair<TFst, TSnd>
    {

    }

    //• scope rules and visibility

    class PersonCatalog{
        private List<Person> Data;
        public void Clear() {
            Data.Clear(); // Data is in scope
            // Person.Far is not
        }
    }


    //• instance and class members
    //• inheritance

    class Employee : Person
    {
        private static int _idc = 0; // class member
        private int id = ++_idc;     // instance member
    }

//• exceptions

    class Manager : Employee
    {
        public void Manage(Employee e)
        {
            if (e == null)
                throw new ArgumentNullException(nameof(e));
        }
    }

//• polymorphism

    class App
    {
        public void Run()
        {
            Employee e = new Employee();

            Manager m = new Manager();

            Manager boss = new Manager();

            m.Manage(e);
            boss.Manage(m); // managers are also employees
            boss.Manage(e);
        }

        void PrintName(Employee e) // static polymorphism
        {
            Console.WriteLine(e.Navn);
        }
        void PrintName(Manager e)
        {
            Console.WriteLine("**** "+e.Navn+" ****");
        }
    }
/*• encapsulation and abstraction
• standard library object-oriented design, architecture and principles
• design patterns
• specialization, implementation and delegation


    // design patterns, collections and throughout the course
*/
//• structured test
    // unit-testing

//• documentation
    /// <summary>
    /// Not covered, no worries
    /// </summary>

    public class Demo
    {
        public void Run()
        {
        }
    }
}