using System;

namespace KG01Exercises
{
    class PersonPrinter
    {
        public void PrintPerson(Person p)
        {
            Console.WriteLine($"{p.Fornavn} {p.Efternavn}, {p.Alder}");
        }

        public void PrintTree(Person p)
        {
            if (p == null)
                return;
            PrintPerson(p);
            PrintTree(p.Far);
            PrintTree(p.Mor);
        }
    }
}