namespace DND_5E_SRD_API.Models
{
    public class Shield
    {
        public string Name { get; set; }
        public int ArmorClass { get; set;}
        public Shield(string name)
        {
            Name = name;
            ArmorClass = 2;
        }


    }
}