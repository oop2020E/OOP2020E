using System;
using System.Collections.Generic;
namespace LiveCode
{

    //interface IA
    //{
    //    void foo();
    //}

    //interface IB
    //{
    //    void foo();
    //}

    //class C : IA, IB
    //{
    //    public void foo()
    //    {

    //    }
    //    void IB.foo()
    //    {

    //    }
    //}


        class Car : INoisy
        {
            public string Name { get; }

            public void MakeNoise()
            {
                Console.WriteLine("wroom");
            }
        }

        interface INamable
        {
            string Name { get; }
        }

        interface INoisy
        { 
            string Name { get; }
            void MakeNoise();
        }

        interface IPet:INamable, INoisy,IComparable { }

        #region Inheritance example

        abstract class Pet
        {
            protected Pet(string name)
            {
                Name = name;
            }
            public string Name { get; set; }
        }

        //TODO 099, Inheritance, Animal-example, object
        class Cat : Pet, INoisy {
            public void MakeNoise()
            {
                Meow();
            }
            public Cat(string navn) :base(navn)
            {
            }
            public void Meow() { }
        }

        class Dog: Pet, INoisy
        {
            public Dog(string d1) :base(d1)
            {
            }

            public void Bark() { }
            public void MakeNoise()
            {
                Bark();
            }
        }

        class Ex00
        {

            void Kick(INoisy n)
            {
                n.MakeNoise();
            }
            void Run()
            {
                Kick(new Cat("K2"));
                Kick(new Car());

                int[] v = new int [10];
                List<int> l = new List<int>();
                Queue<int> q;



                List<INoisy> pets = new List<INoisy>();
                pets.Add(new Cat("k1"));
                pets.Add(new Cat("k2"));
                pets.Add(new Dog("D1"));
                pets.Add(new Dog("d2"));
                pets.Add(new Car());

                INoisy nn = pets[0];

                Console.WriteLine("My pets");
                foreach (INoisy n in pets)
                {
                    Console.WriteLine(n.Name);
                    n.MakeNoise();
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