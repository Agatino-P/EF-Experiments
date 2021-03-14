namespace EF_Experiments.Model
{
    public class Samurai
    {
        public Samurai(string name)
        {
            Name = name;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
    }
}