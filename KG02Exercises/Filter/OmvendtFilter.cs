namespace KG02Exercises.Filter
{
    class OmvendtFilter : PersonFilter
    {
        public OmvendtFilter(PersonFilter filterToBeNegated)
        {
            this.FilterToBeNegated = filterToBeNegated;
        }
        private PersonFilter FilterToBeNegated { get; }
        public override bool Match(Person person) => !FilterToBeNegated.Match(person);
        // ovenstående er kort for:
        //public override bool Match(Person person)
        //{
        //    return !FilterToBeNegated.Match(person);
        //}
    }
}