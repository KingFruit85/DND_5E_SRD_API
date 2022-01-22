using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


namespace DND_5E_SRD_API.Models
{

    public class ArmorList
    {
        [JsonProperty("armor")]
        public List<Armor> Armor { get; set; }
    }

    public class WeaponList
    {
        [JsonProperty("weapon")]
        public List<Weapon> weapon { get; set; }
    }

    public class ArtisansToolList
    {
        [JsonProperty("ArtisansTools")]
        public List<ArtisansTools> artisansTools { get; set; }
    }

    public class MusicalInstrumentList
    {
        [JsonProperty("MusicalInstruments")]
        public List<MusicalInstrument> MusicalInstruments { get; set; }
    }

    public class EquipmentPackList
    {
        [JsonProperty("Equipment Packs")]
        public List<EquipmentPack> EquipmentPacks { get; set; }
    }

    public class Equipment
    {
        public ArmorList ReturnArmorList()
        {
            var armor = File.ReadAllText(@"E:\Coding projects\dnd\data\Armor\armor.json");
            return JsonConvert.DeserializeObject<ArmorList>(armor);
        }

        public WeaponList ReturnWeaponList()
        {
            var weapons = File.ReadAllText(@"E:\Coding projects\dnd\data\Weapons\Weapons.json");
            return JsonConvert.DeserializeObject<WeaponList>(weapons);
        }

        public ArtisansToolList ReturnArtisansToolList()
        {
            var tools = File.ReadAllText(@"E:\Coding projects\dnd\data\Equipment\Misc\ArtisansTools.json");
            return JsonConvert.DeserializeObject<ArtisansToolList>(tools);
        }
        public MusicalInstrumentList MusicalInstrument()
        {
            var instruments = File.ReadAllText(@"E:\Coding projects\dnd\data\Equipment\MusicalInstruments\MusicalInstruments.json");
            return JsonConvert.DeserializeObject<MusicalInstrumentList>(instruments);
        }

        public EquipmentPackList EquipmentPacks()
        {
            var packs = File.ReadAllText(@"E:\Coding projects\dnd\data\Equipment\Packs\Packs.json");
            return JsonConvert.DeserializeObject<EquipmentPackList>(packs);
        }


    }    
}