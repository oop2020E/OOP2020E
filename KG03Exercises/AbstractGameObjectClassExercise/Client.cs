//From http://people.cs.aau.dk/~normark/oop-csharp/html/notes/more-inheritance-interfaces-ex-slide-exercise-1.html

using System;
using LibOOP;

namespace KG03Exercises.AbstractGameObjectClassExercise
{
    public class Client : IExerciseSolution
    {
        public void Run()
        {
            Die d1 = new Die(),
                d2 = new Die(10),
                d3 = new Die(18);

            Card c1 = new Card(Card.CardSuite.spades, Card.CardValue.queen),
                c2 = new Card(Card.CardSuite.clubs, Card.CardValue.four),
                c3 = new Card(Card.CardSuite.diamonds, Card.CardValue.ace);

            IGameObject[] gameObjects = { d1, d2, d3, c1, c2, c3 };

            foreach (IGameObject gao in gameObjects)
            {
                Console.WriteLine("{0}: {1} {2}",
                    gao, gao.GameValue, gao.Medium);
            }
        }
    }
}