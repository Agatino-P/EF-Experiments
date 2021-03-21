using System.Collections.Generic;
using System.Linq;

namespace EF_Experiments.Model
{
    public class Samurai
    {
        //        public int Id { get; private set; }
        public int Id { get; private set; }
        public string Name { get; private set; }

        private List<Quote> _quotes = new();
        public IReadOnlyList<Quote> Quotes => _quotes.ToList();

        public void AddQuote(Quote quote)
        {
            if (quote == null)
                return;
            _quotes.Add(quote);
        }

        public void AddQuote(string text)
        {
            if (text == null)
                return;
            _quotes.Add(new Quote(text,this));
        }


        public Samurai(string name)
        {
            Name = name;
        }

       
    }
}