using DND_5E_SRD_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DND_5E_SRD_API.Controllers
{
    public class Bard : GenericCharacterClass
    {
        public Bard()
        {
            SetName("bard");
            HitDie = "1d8";

            ///////////////////
            // PROFICIENCIES //
            ///////////////////
            
            SetProficiencyBonus(2);

            var Proficiencies = new Dictionary<string,List<string>>()
            {
                {"armor", new List<string>(){"Light Armor"}},
                {"weapons",new List<string>(){"Simple Weapons", "Hand Crossbows", "Longswords", "Rapiers", "Shortswords"}},
                {"tools", new List<string>()},
                {"saving throws", new List<string>(){"Dexterity", "Charisma"}},
                {"skills", new List<string>(){}}
            };

            // Get 3 random instrument profs
            var instrumentList = new Equipment().MusicalInstrument().MusicalInstruments;
            instrumentList = Tools.ShuffleList(instrumentList);
            Proficiencies["tools"].Add(instrumentList[0].Name);
            Proficiencies["tools"].Add(instrumentList[1].Name);
            Proficiencies["tools"].Add(instrumentList[2].Name);

            var bardSkillProfs = new List<string>()
            {
                "athletics",
                "acrobatics",
                "sleightOfHand",
                "arcana",
                "stealth",
                "history",
                "nature",
                "religion",
                "animalHandling",
                "insight",
                "medicine",
                "perception",
                "survival",
                "deception",
                "intimidation",
                "investigation",
                "performance",
                "persuasion"
            };

            // Get 3 ransom skill profs
            bardSkillProfs = Tools.ShuffleList(bardSkillProfs);
            Proficiencies["skills"].Add(bardSkillProfs[0]);
            Proficiencies["skills"].Add(bardSkillProfs[1]);
            Proficiencies["skills"].Add(bardSkillProfs[2]);

            SetProficiencies(Proficiencies);

            ///////////////
            // EQUIPMENT //
            ///////////////

            // Bards get either a Lute or a random musical instrument
            // My implimentation only adds a lute if we're proficient
            // If not, then add a random instrument we are proficient in

            if (Proficiencies["tools"].Contains("Lute"))
            {
                var lute = new Equipment().MusicalInstrument().MusicalInstruments.Where(i => i.Name == "Lute").ToList()[0];
                MusicalInstruments.Add(lute);
            }
            else
            {
                // Get a random instrument we are proficient in as a string
                var proficientInstrument = Tools.ShuffleList(Proficiencies["tools"]).ToList()[0];
                // Reterive the instrument object
                var instrument = new Equipment().MusicalInstrument().MusicalInstruments.Where(i => i.Name == proficientInstrument).ToList()[0];
                MusicalInstruments.Add(instrument);
            }

            // All bards get a dagger and leather armor
            var dagger = GetWeapons().Where(w => w.Name == "Dagger").ToList()[0];
            AdditionalWeapons.Add(dagger);

            Armor = GetArmor().Where(a => a.Name == "Leather Armor").ToList()[0];

            // They also get either a Diplomat's pack or and entertainer's pack
            switch (Tools.GetRandomNumberInRange(0,1))
            {
                default: throw new Exception("Option no valid");
                case 0:
                    EquipmentPack = GetPacks().Where(p => p.Name == "Diplomat's Pack").ToList()[0];
                    break;
                case 1:
                    EquipmentPack= GetPacks().Where(p => p.Name == "Entertainer's Pack").ToList()[0];
                    break;
            }

            // They also get either a Rapier, Longsword or a any simple weapon
            switch (Tools.GetRandomNumberInRange(0,2))
            {
                default: throw new Exception("Option no valid");
                case 0:
                    PrimaryWeapon = GetWeapons().Where(w => w.Name == "Rapier").ToList()[0];
                    break;
                case 1:
                    PrimaryWeapon = GetWeapons().Where(w => w.Name == "Longsword").ToList()[0];
                    break;
                case 2:
                    var randomSimpleWeapon = GetWeapons().Where(w => w.WeaponType == "Simple Melee").ToList();
                    randomSimpleWeapon = Tools.ShuffleList(randomSimpleWeapon);
                    PrimaryWeapon = randomSimpleWeapon[0];
                    break;
            }

            //////////////
            //  SPELLS  //
            //////////////

            // At level 1 bards get 
            // 2 x Cantrips
            // 2 x 1st level spells

            SpellSlots = 2;

            List<string> bardCantrips = new List<string>()
            {
                "Dancing Lights",
                "Light",
                "Mage Hand",
                "Mending",
                "Message",
                "Minor Illusion",
                "Prestidigitation",
                "True Strike"
            };

            Cantrips = Tools.ReturnXSpellsFromList(bardCantrips,2);

            List<string> bardLevel1Spells = new List<string>()
            {
                "Bane",
                "Charm Person",
                "Comprehend Languages",
                "Cure Wounds",
                "Detect Magic",
                "Disguise Self",
                "Faerie Fire",
                "Feather Fall",
                "Healing Word",
                "Heroism",
                "Hideous Laughter",
                "Identify",
                "Illusory Script",
                "Longstrider",
                "Silent Image",
                "Sleep",
                "Speak with Animals",
                "Thunderwave",
                "Unseen Servant"
            };

            Level1Spells = Tools.ReturnXSpellsFromList(bardLevel1Spells,SpellSlots);

            //////////////
            // FEATURES //
            //////////////

            // Add Bard Features
            Features.Add(new Feature("Spellcasting", "", 1));
            Features.Add(new Feature("Bardic Inspiration (d6)","",1));

        }
    }
}