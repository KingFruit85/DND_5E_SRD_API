using DND_5E_SRD_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace DND_5E_SRD_API.Controllers
{
    public class Rogue : GenericCharacterClass
    {
        public Rogue()
        {
            SetName("rogue");
            HitDie = "1d8";

            ///////////////////
            // PROFICIENCIES //
            ///////////////////
            
            SetProficiencyBonus(2);
            var Proficiencies = new Dictionary<string,List<string>>()
            {
                {"armor", new List<string>(){"Light Armor"}},
                {"weapons",new List<string>(){"Simple Weapons", "Hand Crossbow", "Longsword", "Rapiers", "Shortsword"}},
                {"tools", new List<string>(){"Thieves’ Tools"}},
                {"saving throws", new List<string>(){"Dexterity", "Intelligence"}},
                {"skills", new List<string>(){}}
            };

            // Rogues can select four skills from the following list
            var rogueSkillProfs = new List<string>()
            {
                 "acrobatics", 
                 "athletics", 
                 "Deception", 
                 "insight", 
                 "intimidation", 
                 "investigation", 
                 "perception", 
                 "Performance", 
                 "persuasion", 
                 "Sleight of Hand",
                 "stealth"
            };

            // Shuffle list and add the top four
            rogueSkillProfs = Tools.ShuffleList(rogueSkillProfs);
            Proficiencies["skills"].Add(rogueSkillProfs[0]);
            Proficiencies["skills"].Add(rogueSkillProfs[1]);
            Proficiencies["skills"].Add(rogueSkillProfs[2]);
            Proficiencies["skills"].Add(rogueSkillProfs[3]);


            SetProficiencies(Proficiencies);

            ///////////////
            // EQUIPMENT //
            ///////////////

            // Rogues start with a rapier or a shortsword
            Weapon rapier = GetWeapons().Where(w => w.Name == "Rapier").ToList()[0];
            Weapon longSword = GetWeapons().Where(w => w.Name == "Longsword").ToList()[0];

            switch (Tools.GetRandomNumberInRange(0,1))
                        {
                            default: throw new System.Exception("number not in range");
                            case 0:
                                PrimaryWeapon = rapier;
                                break;
                            case 1:
                                PrimaryWeapon = longSword;
                                break;
                        }

            // a shortbow and quiver of 20 arrows or a shortsword
            Weapon shortSword = GetWeapons().Where(w => w.Name == "Shortsword").ToList()[0];
            Weapon shortBow = GetWeapons().Where(w => w.Name == "Shortbow").ToList()[0];

            switch (Tools.GetRandomNumberInRange(0,1))
                        {
                            default: throw new System.Exception("number not in range");
                            case 0:
                                AdditionalWeapons.Add(shortSword);      
                                break;
                            case 1:
                                AdditionalWeapons.Add(shortBow);
                                Ammunition.Add(new Ammunition("shortbow arrows",20,"A quiver of shortbow arrows"));
                                break;   
                        }

            // a burglar’s pack, a dungeoneer’s pack, or an explorer’s pack
            switch (Tools.GetRandomNumberInRange(0,2))
            {
                default: throw new System.Exception("number not in range");
                case 0:
                    EquipmentPack = GetPacks().Where(p => p.Name == "Dungeoneer's Pack").ToList()[0];
                    break;
                case 1:
                    EquipmentPack = GetPacks().Where(p => p.Name == "Explorer's Pack").ToList()[0];
                    break;
                case 2:
                    EquipmentPack = GetPacks().Where(p => p.Name == "Burglar's Pack").ToList()[0];
                    break;
            }

            // Leather armor, two daggers, and thieves’ tools
            Armor = GetArmor().Where(a => a.Name == "Leather Armor").ToList()[0];
            AdditionalWeapons.Add(GetWeapons().Where(w => w.Name == "Dagger").ToList()[0]);
            AdditionalWeapons.Add(GetWeapons().Where(w => w.Name == "Dagger").ToList()[0]);
            OtherEquipment.Add("Thieves’ Tools");

            //////////////
            // FEATURES //
            //////////////

            Features.Add(new Feature("Expertise","",1));
            Features.Add(new Feature("Sneak Attack","",1));
            Features.Add(new Feature("Thieves’ Cant","",1));



        }
    }
}