//From http://people.cs.aau.dk/~normark/oop-csharp/html/notes/more-inheritance-interfaces-ex-slide-exercise-1.html

namespace KG03Exercises.AbstractGameObjectClassExercise
{
    interface IGameObject
    {

        int GameValue
        {
            get;
        }

        GameObjectMedium Medium
        {
            get;
        }
    }
}