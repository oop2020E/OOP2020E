//From http://people.cs.aau.dk/~normark/oop-csharp/html/notes/more-inheritance-interfaces-ex-slide-exercise-1.html

using System;

namespace KG03Exercises.AbstractGameObjectClassExercise
{
    class Die : IGameObject
    {
        private int numberOfEyes;
        private Random randomNumberSupplier;
        private readonly int maxNumberOfEyes;

        public Die() : this(6) { }

        public Die(int maxNumberOfEyes)
        {
            randomNumberSupplier =
                new Random(unchecked((int)DateTime.Now.Ticks));
            this.maxNumberOfEyes = maxNumberOfEyes;
            numberOfEyes = NewTossHowManyEyes();
        }

        public void Toss()
        {
            numberOfEyes = NewTossHowManyEyes();
        }

        private int NewTossHowManyEyes()
        {
            return randomNumberSupplier.Next(1, maxNumberOfEyes + 1);
        }

        public int NumberOfEyes()
        {
            return numberOfEyes;
        }

        public override String ToString()
        {
            return String.Format("Die[{0}]: {1}", maxNumberOfEyes, numberOfEyes);
        }

        public int GameValue
        {
            get
            {
                return numberOfEyes;
            }
        }

        public GameObjectMedium Medium
        {
            get
            {
                return
                    GameObjectMedium.Plastic;
            }
        }

    }
}