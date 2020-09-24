using LibOOP;

namespace KG01Exercises
{
    public class KG01ExerciseSolution : IExerciseSolution
    {
        public void Run()
        {
            Person mig = new Person(20, "Thomas", "Thomasson", 
                new Person(60, "Farmand", "Farsen", 
                    new Person(100, "Farfar", "farfarsen"), 
                    new Person(100, "Farmor", "Farmorsen") 
                    ), 
                new Person(60, "Mor", "Morsen",
                    new Person(100, "Morfar", "Morfarsen"),
                    new Person(100, "Mormor", "Mormorsen")
                    )
                );
            PersonPrinter pp = new PersonPrinter();
            pp.PrintTree(mig);
        }
    }
}
