namespace DungeonsData.Models
{
    public class Spell
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public List<string> Desc { get; set; }
        public List<string> Higher_Level { get; set; }
        public string Range { get; set; }
        public List<string> Components { get; set; }
        public string Material { get; set; }
        public bool Ritual { get; set; }
        public string Duration { get; set; }
        public bool Concentration { get; set; }
        public string Casting_Time { get; set; }
        public int Level { get; set; }
        public string Attack_Type { get; set; }
        public Damage Damage { get; set; }
        public School School { get; set; }
        public List<Class> Classes { get; set; }
        public List<Subclass> Subclasses { get; set; }
        public string Url { get; set; }
    }
}
