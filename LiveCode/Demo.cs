using System;
using System.Collections.Generic;
namespace LiveCode
{
    public class Demo
    {

        #region Inheritance example
        //TODO 099, Inheritance, Animal-example, object
        class Cat
        {
            public string Name { get; set; }
            public void Meow() { }
        }

        class Dog
        {
            public string Name { get; set; }
            public void Bark() { }
        }

        class Ex00
        {
            void Run()
            {
                List<Cat> cats = new List<Cat>();
                cats.Add(new Cat());
                cats.Add(new Cat());

                List<Dog> dogs = new List<Dog>();
                dogs.Add(new Dog());
                dogs.Add(new Dog());

                Console.WriteLine("My pets");
                foreach (var dog in dogs)
                {
                    Console.WriteLine(dog.Name);
                }

                foreach (var cat in cats)
                {
                    Console.WriteLine(cat.Name);
                }
            }
        }

        #endregion




        #region DataChannel


        //TODO 100 multiple inheritance
        abstract class DataChannel
        {
            public abstract void Send(byte[] data);
            public abstract byte[] Recv();
        }

        abstract class Connection
        {
            public abstract void Connnect();
            public abstract void Disconnect();
        }



        class ResourceManager
        {
            public void Manage(Connection c) { }
        }

        class MyChatProgram
        {
            public MyChatProgram(DataChannel c)
            {
                byte[] data = c.Recv();
            }
        }

        #endregion

        //TODO


    }
}