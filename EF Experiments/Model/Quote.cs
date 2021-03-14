namespace EF_Experiments.Model
{
    public class Quote
    {
        public int Id { get; private set; }
        public string Text { get; private set; }
        public int SamuraiId { get; private set; }
        public Samurai Samurai { get; private set; }
        protected Quote()
        {

        }

        public Quote(string text, Samurai samurai)
        {
            Text = text;
            Samurai = samurai;
            SamuraiId = samurai.Id;
        }
    }
}