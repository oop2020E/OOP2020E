namespace KG02Exercises.Filter
{
    class MereGenerelVersionAfNavneFilteret : PersonFilter
    {
        public string Navn { get; set; }

        public MereGenerelVersionAfNavneFilteret(string navn)
        {
            Navn = navn;
        }

        public override bool Match(Person person)
        {
            return person.Navn == Navn;
        }
    }
}