namespace EF_Experiments.Model
{
    public class Quote
    {
        public int Id { get; private set; }
        public string Text { get; private set; }
        public Samurai Samurai { get; private set; }

        
        private Quote() { } //EF
        public Quote(string text, Samurai samurai)
        {
            Text = text;
            Samurai = samurai;
        }
    }
}