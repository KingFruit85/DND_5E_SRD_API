using DND_5E_SRD_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace DND_5E_SRD_API.Controllers
{
    public class Ranger : GenericCharacterClass
    {
        public Ranger()
        {
            SetName("ranger");
            HitDie = "1d10";

            ///////////////////
            // PROFICIENCIES //
            ///////////////////
            
            SetProficiencyBonus(2);
            var Proficiencies = new Dictionary<string,List<string>>()
            {
                {"armor", new List<string>(){ "Light Armor", "Medium Armor", "Shields"}},
                {"weapons",new List<string>(){"Simple Weapons", "Martial Weapons"}},
                {"tools", new List<string>()},
                {"saving throws", new List<string>(){"Strength", "Dexterity"}},
                {"skills", new List<string>(){}}
            };

            // Paladins can select two skills from the following list
            var rangerSkillProfs = new List<string>()
            {
                "animal handling", 
                "athletics", 
                "insight", 
                "investigation", 
                "nature", 
                "perception", 
                "stealth",
                "survival"
            };

            // Shuffle list and add the top three
            rangerSkillProfs = Tools.ShuffleList(rangerSkillProfs);
            Proficiencies["skills"].Add(rangerSkillProfs[0]);
            Proficiencies["skills"].Add(rangerSkillProfs[1]);
            Proficiencies["skills"].Add(rangerSkillProfs[2]);

            SetProficiencies(Proficiencies);


            ///////////////
            // EQUIPMENT //
            ///////////////

            // Rangers start with two shortswords or two simple melee weapons
            Weapon shortSword = GetWeapons().Where(w => w.Name == "Shortsword").ToList()[0];
            List<Weapon> simpleWeapons = Tools.ShuffleList(GetWeapons().Where(w => w.WeaponType == "Simple Melee").ToList());

            switch (Tools.GetRandomNumberInRange(0,1))
            {
                default: throw new System.Exception("number not in range");
                case 0:
                    PrimaryWeapon = shortSword;
                    OffHandWeapon = shortSword;
                    break;
                case 1:
                    PrimaryWeapon = simpleWeapons[0];
                    OffHandWeapon = simpleWeapons[1];
                    break;
                    
            }
            // scale mail or leather armor
            switch (Tools.GetRandomNumberInRange(0,1))
            {
                default: throw new System.Exception("number not in range");
                case 0:
                    Armor = GetArmor().Where(a => a.Name == "Scale Mail").ToList()[0];
                    break;
                case 1:
                    Armor = GetArmor().Where(a => a.Name == "Leather Armor").ToList()[0];
                    break;
            }

            // a dungeoneer’s pack or an explorer’s pack
            switch (Tools.GetRandomNumberInRange(0,1))
            {
                default: throw new System.Exception("number not in range");
                case 0:
                    EquipmentPack = GetPacks().Where(p => p.Name == "Dungeoneer's Pack").ToList()[0];
                    break;
                case 1:
                    EquipmentPack = GetPacks().Where(p => p.Name == "Explorer's Pack").ToList()[0];
                    break;
            }

            // A longbow and a quiver of 20 arrows
            AdditionalWeapons.Add(GetWeapons().Where(w => w.Name == "Longbow").ToList()[0]);
            Ammunition.Add(new Ammunition("longbow arrows",20,"A quiver of longbow arrows"));

            //////////////
            // FEATURES //
            //////////////

            Features.Add(new Feature("Favored Enemy","",1));

            List<string> favoredEnemyList = new List<string>()
            {
                "aberrations", 
                "beasts", 
                "celestials", 
                "constructs", 
                "dragons", 
                "elementals", 
                "fey", 
                "fiends", 
                "giants", 
                "monstrosities", 
                "oozes", 
                "plants",
                "undead"
            };

            // Will need to add the rest later, need to confirm an SRD list
            List<string> alternativefavoredEnemyList = new List<string>()
            {
                "gnolls",
                "orcs",
                "bugbears",
                "drow",
                "duergar",
                "dwarves",
                "elves",
                "gnomes",
                "goblins",
                "half-orcs",
                "half-elfs",
                "halflings",
                "hobgoblins",
                "humans",
                "kobolds",
                "lizardfolk",
                "maenads",
                "merfolk",
                "orcs",
                "svirfneblin",
                "troglodytes",
                "vampires",
                "werebears",
                "wereboars",
                "wererats",
                "weretigers",
                "werewolves",
                "Xephs"
            };

            switch (Tools.GetRandomNumberInRange(0,1))
            {
                default: throw new System.Exception("number not in range");
                case 0:
                    FavoredEnemy.Add(Tools.ShuffleList(favoredEnemyList)[0]);
                    break;
                case 1:
                    var shuffledAltList = Tools.ShuffleList(alternativefavoredEnemyList);
                    FavoredEnemy.Add(shuffledAltList[0]);
                    FavoredEnemy.Add(shuffledAltList[1]);
                    break;
            }

            Features.Add(new Feature("Natural Explorer","",1));

            List<string> favoredTerrain = new List<string>()
            {
                "arctic", 
                "coast", 
                "desert", 
                "forest", 
                "grassland", 
                "mountain",
                "swamp"
            };
            FavoredTerrain = Tools.ShuffleList(favoredTerrain)[0];
        }
    }
}