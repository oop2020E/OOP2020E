namespace KG02Exercises.Filter
{
    class SuperFilter : PersonFilter
    {
        public SuperFilter(PersonFilter pf1, PersonFilter pf2)
        {
            this.pf1 = pf1;
            this.pf2 = pf2;
        }
        public PersonFilter pf1 { get; set; }
        public PersonFilter pf2 { get; set; }
        public override bool Match(Person person)=> pf1.Match(person) && pf2.Match(person);
        
    }
}