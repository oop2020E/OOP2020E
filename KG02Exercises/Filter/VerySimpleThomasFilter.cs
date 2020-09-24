namespace KG02Exercises.Filter
{
    class VerySimpleThomasFilter : PersonFilter
    {
        public override bool Match(Person person)
        {
            // det samme som if(person.Navn == "Thomas") return true; else return false;!
            return person.Navn == "Thomas";
        }
    }
}