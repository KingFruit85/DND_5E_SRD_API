namespace DND_5E_SRD_API.Models
{
    public class Ammunition
    {
        public string Name {get; set;}
        public int Count {get; set;}
        public string Description {get; set;}

        public Ammunition(string name, int count, string description)
        {
            Name = name;
            Count = count;
            Description = description;
        }
    }
}