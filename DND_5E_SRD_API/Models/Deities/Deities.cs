namespace DND_5E_SRD_API.Models
{

    public class Deity
    {
        public string DeityName { get; set; }
        public string Details { get; set; }
        public string Alignment { get; set; }
        public string Symbol { get; set; }

        public void SetDeityName(string name)
        {
            DeityName = name;
        }
    }
      

    public class Aphrodite : Deity
    {
        public Aphrodite()
        {
            DeityName  = "Aphrodite";
            Details = "Goddess of love and beauty";
            Alignment = "Chaotic Good";
            Symbol = "Sea shell";
        }
    }


    // Something fun to do later... 


    // Hera, goddess of marriage and intrigue	CN	Trickery	Fan of peacock feathers
    // Hercules, god of strength and adventure	CG	Tempest, War	Lion's head
    // Hermes, god of travel and commerce	CG	Trickery	Caduceus (winged staff and serpents)
    // Hestia, goddess of home and family	NG	Life	Hearth
    // Nike, goddess of victory	LN	War	Winged woman
    // Pan, god of nature	CN	Nature	Syrinx (pan pipes)
    // Poseidon, god of the sea and earthquakes	CN	Tempest	Trident
    // Tyche, goddess of good fortune	N	Trickery	Red pentagram



}
