using System;
using System.Collections.Generic;
using System.Linq;

namespace DND_5E_SRD_API.Models
{
    public class GenericRace
    {
        public string Name {get;set;}
        public Dictionary<string, int> AbilityScoreIncrease {get;set;} = new Dictionary<string, int>();
        public int Age { get; set; }
        public string Alignment { get; set; }
        public string Size { get; set; }
        public int Speed { get; set; }
        public List<string> Languages { get; set; } = new List<string>();
        public string SubRace { get; set; }
        public Dictionary<string, string> RacePerks {get;set;} = new Dictionary<string, string>();
        public List<string> RaceSkillProficienciesToAdd = new List<string>();
        public List<string> RaceWeaponProficienciesToAdd = new List<string>();
        public List<string> RaceArmorProficienciesToAdd = new List<string>();
        public List<string> RaceToolProficienciesToAdd = new List<string>();

        public List<string> SpellsToAdd = new List<string>();

        public List<Feature> FeaturesToAdd = new List<Feature>();
                              
        public struct DraconicAncestryDetails
        {
            public string Name;
            public string DamageType;
            public string BreathWeapon;
        } 
        private DraconicAncestryDetails DraconicAncestry {get;set;}

        /// <summary>Adds a proficiency represented as a string into the collection identified by the second param</summary>
        /// <param name="proficiency">a string representing a racial proficiency</param>
        /// <param name="type">a string representing the type of proficiency the first param is</param>
        public void AddRaceProficiency(string proficiency, string type)
        {
            switch (type)
            {
                default: throw new Exception("provided proficiency type is unknown");
                case "skill":
                    RaceSkillProficienciesToAdd.Add(proficiency);
                    break;
                case "weapon":
                    RaceWeaponProficienciesToAdd.Add(proficiency);
                    break;
                case "armor":
                    RaceArmorProficienciesToAdd.Add(proficiency);
                    break;
                case "tool":
                    RaceToolProficienciesToAdd.Add(proficiency);
                    break; 
            }
        }
        /// <summary>Adds proficiencies represented as a List<string> into the collection identified by the second param</summary>
        /// <param name="proficiency">a List <string> containing one or more <string>'s representing a racial proficiency</param>
        /// <param name="type">a string representing the type of proficiency the first param is</param>
        public void AddRaceProficiency(List<string> proficiencies, string type)
        {
            switch (type)
            {
                default: throw new Exception("provided proficiency type is unknown");
                case "skill":
                    foreach (var prof in proficiencies)
                    {
                        RaceSkillProficienciesToAdd.Add(prof);
                    }
                    break;
                case "weapon":
                    foreach (var prof in proficiencies)
                    {
                        RaceWeaponProficienciesToAdd.Add(prof);
                    }
                    break;
                case "armor":
                    foreach (var prof in proficiencies)
                    {
                        RaceArmorProficienciesToAdd.Add(prof);
                    }
                    break;
                case "tool":
                    foreach (var prof in proficiencies)
                    {
                        RaceToolProficienciesToAdd.Add(prof);
                    }
                    break; 
            }
        }

        /// <summary>Returns a dictionary containing any racial proficiency bonuses<string></summary>
        public Dictionary<string,List<string>> ReturnRacialProficiencies()
        {
            var Proficiencies = new Dictionary<string,List<string>>()
            {
                {"armor", new List<string>(){}},
                {"weapons",new List<string>(){}},
                {"tools", new List<string>()},
                {"saving throws", new List<string>(){}},
                {"skills", new List<string>(){}}
            };
            
            if (RaceSkillProficienciesToAdd != null)
            {
                foreach (var skill in RaceSkillProficienciesToAdd)
                {
                    Proficiencies["skills"].Add(skill);
                }
            }

            if (RaceWeaponProficienciesToAdd != null)
            {
                foreach (var skill in RaceWeaponProficienciesToAdd)
                {
                    Proficiencies["weapons"].Add(skill);
                }
            }

            if (RaceArmorProficienciesToAdd != null)
            {
                foreach (var skill in RaceArmorProficienciesToAdd)
                {
                    Proficiencies["armor"].Add(skill);
                }
            }

            if (RaceToolProficienciesToAdd != null)
            {
                foreach (var skill in RaceToolProficienciesToAdd)
                {
                    Proficiencies["tools"].Add(skill);
                }
            }

            return Proficiencies;
        }
        
        

        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public Dictionary<string, int> GetAbilityScoreIncrease()
        {
            return AbilityScoreIncrease;
        }
        public void SetAbilityScoreIncrease(string attribute, int modifier)
        {
            this.AbilityScoreIncrease.Add(attribute, modifier);
        }
        public int GetAge()
        {
            return Age;
        }
        public void SetAge(int age)
        {
            if (age == 0)
            {
                throw new Exception("age cannot be 0!");
            }
            else
            {
                Age = age;
            }

        }

        public string GetAlignment()
        {
            return Alignment;
        }

        // Returns a random alignment. useful for races with no strong alignment to any alignment
        public void SetAlignment()
        {
            var Alignments = new List<string>{
                              "lawful good",
                              "neutral good",
                              "chaotic good",
                              "lawful neutral",
                              "true neutral",
                              "chaotic neutral",
                              "lawful evil",
                              "neutral evil",
                              "chaotic evil"};

            Alignment = Tools.GetRandomListElement(Alignments);
        }

        // Takes in the races weighted alignment list and returns an alignment
        public void SetAlignment(List<KeyValuePair<string,float>> raceAlignments)
        {
            var alignments = raceAlignments;
            var newWeightedAlignments = new List<KeyValuePair<string,float>>();
            
            // For each key in the raceAlignments param we're going to add a random float to the 
            // key's value that will increase it randomly but will not exceed a value of 1.0f
            foreach (var item in alignments)
            {
                var r = new Random();
                var weightToAdd = r.NextDouble();
                var newWeight = item.Value + (weightToAdd - item.Value);
                newWeightedAlignments.Add(new KeyValuePair<string, float>(item.Key, (float)newWeight));
            }
            
            // Sorts the KVP list by Value in decenting order 
            newWeightedAlignments.Sort((x, y) => (y.Value.CompareTo(x.Value)));
            // Sets the alignment
            Alignment = newWeightedAlignments[0].Key;
            
        }

        public string GetSize()
        {
            return Size;
        }
        public void SetSize(string size)
        {
            Size = size;
        }

        public int GetSpeed()
        {
            return Speed;
        }

        public void SetSpeed(int speed)
        {
            Speed = speed;
        }

        public List<string> GetLanguages()
        {
            return Languages;
        }

        public void AddLanguage(string lang)
        {
            if (this.Languages.Contains(lang))
            {
                throw new Exception($"character already knows {lang}");
            }
            else
            {
                this.Languages.Add(lang);
            }
        }

        public Dictionary<string,string> GetRacePerks()
        {
            return RacePerks;
        }
        public void SetRacePerk(string name, string description)
        {
            this.RacePerks.Add(name, description);
        }
        
        /// <summary>Adds a random selection of languages to the characters known languages<DraconicAncestryDetails></summary>
        /// <param name="count">The number of languages to add<int></param>
        public void AddLanguage(int count = 1)
        {
            // Initialise standard languages
            var StandardLanguages = new List<string>{"common","dwarvish","elvish","giant","gnomish","goblin","halfling","orc"};
            // Select a random language    
            var Pick = Tools.GetRandomListElement(StandardLanguages);
                // Loop through argument count
                for(var i = 0; i< count; i++)
                {
                // Check if character already knows random pick
                var AlreadyPresent = this.Languages.Contains(Pick);

                if(AlreadyPresent == true) 
                {
                    Pick = Tools.GetRandomListElement(StandardLanguages);
                    i--;
                }
                else
                {
                    this.Languages.Add(Pick);
                }
                }
        }

        public string getSubRace()
        {
            return SubRace;
        }

        public void SetSubRace(string subRace)
        {
            SubRace = subRace;
        }

        public DraconicAncestryDetails GetDraconicAncestry()
        {
            return DraconicAncestry;
        }

        public void SetDraconicAncestryDetails(DraconicAncestryDetails x)
        {
            DraconicAncestry = x;
        }
    }

    public class Human : GenericRace
    {
        public Human()
        {
        SetName("human");
        // Humans reach adulthood in their late teens and live less than a century.
        SetAge(Tools.GetRandomNumberInRange(18,65));
        // Human ability scores each increase by 1.
        
        SetAbilityScoreIncrease("str", 1);
        SetAbilityScoreIncrease("dex", 1);
        SetAbilityScoreIncrease("con", 1);
        SetAbilityScoreIncrease("int", 1);
        SetAbilityScoreIncrease("cha", 1);
        SetAbilityScoreIncrease("wis", 1);
        // Humans tend toward no particular alignment. The best and the worst are found among them.
        SetAlignment();
        // Humans vary widely in height and build, from barely 5 feet to well over 6 feet tall. 
        // Regardless of your position in that range, your size is Medium.
        SetSize("medium");
        // Human base walking speed is 30 feet.
        SetSpeed(30);
        // Humans know Common by default
        AddLanguage("common");
        // Humans also know one additional language other than common
        AddLanguage(1);
        }
    }
    public class Dragonborn : GenericRace
    {
        public Dragonborn()
        {
            SetName("dragonborn");

            SetRacePerk("ability score increase", "Your Strength score increases by 2, and your Charisma score increases by 1.");
            SetAbilityScoreIncrease("str", 2);
            SetAbilityScoreIncrease("cha", 1);

            SetRacePerk("age"," Young dragonborn grow quickly. They walk hours after hatching, attain the size and development of a 10-year-old human child by the age of 3, and reach adulthood by 15. They live to be around 80.");
            SetAge(Tools.GetRandomNumberInRange(15,80));

            SetRacePerk("alignment","Dragonborn tend to extremes, making a conscious choice for one side or the other in the cosmic war between good and evil. Most dragonborn are good, but those who side with evil can be terrible villains.");
            
            List<KeyValuePair<string, float>> weightedAlignments = new List<KeyValuePair<string, float>>()
                {
                    new KeyValuePair<string, float>("lawful good",0.3f),
                    new KeyValuePair<string, float>("neutral good",0f),
                    new KeyValuePair<string, float>("chaotic good",0.2f),
                    new KeyValuePair<string, float>("lawful neutral",0f),
                    new KeyValuePair<string, float>("true neutral",0f),
                    new KeyValuePair<string, float>("chaotic neutral",0f),
                    new KeyValuePair<string, float>("lawful evil",0.3f),
                    new KeyValuePair<string, float>("neutral evil",0f),
                    new KeyValuePair<string, float>("chaotic evil",0.2f),
                };

            SetAlignment(weightedAlignments);

            SetRacePerk("size","Dragonborn are taller and heavier than humans, standing well over 6 feet tall and averaging almost 250 pounds. Your size is Medium.");
            SetSize("medium");

            SetRacePerk("speed","Your base walking speed is 30 feet.");
            SetSpeed(30);

            SetRacePerk("Draconic Ancestry","You have draconic ancestry. Choose one type of dragon from the Draconic Ancestry table. Your breath weapon and damage resistance are determined by the dragon type.");
            
            var DraconicAncestry = new List<DraconicAncestryDetails>()
            {
                {new DraconicAncestryDetails(){Name = "Black", DamageType = "Acid", BreathWeapon = "5 by 30 ft. line (Dex. save)"}},
                {new DraconicAncestryDetails(){Name = "Blue", DamageType = "Lightning", BreathWeapon = "5 by 30 ft. line (Dex. save)"}},
                {new DraconicAncestryDetails(){Name = "Brass", DamageType = "Fire", BreathWeapon = "5 by 30 ft. line (Dex. save)"}},
                {new DraconicAncestryDetails(){Name = "Bronze", DamageType = "Lightning", BreathWeapon = "5 by 30 ft. line (Dex. save)"}},
                {new DraconicAncestryDetails(){Name = "Copper", DamageType = "Acid", BreathWeapon = "5 by 30 ft. line (Dex. save)"}},
                {new DraconicAncestryDetails(){Name = "Gold", DamageType = "Fire", BreathWeapon = "15 ft. cone (Dex. save)"}},
                {new DraconicAncestryDetails(){Name = "Green", DamageType = "Poison", BreathWeapon = "15 ft. cone (Dex. save)"}},
                {new DraconicAncestryDetails(){Name = "Red", DamageType = "Fire", BreathWeapon = "15 ft. cone (Dex. save)"}},
                {new DraconicAncestryDetails(){Name = "Silver", DamageType = "Cold", BreathWeapon = "15 ft. cone (Dex. save)"}},
                {new DraconicAncestryDetails(){Name = "White", DamageType = "Cold", BreathWeapon = "15 ft. cone (Dex. save)"}}  
            };

            SetDraconicAncestryDetails(Tools.GetRandomListElement(DraconicAncestry));

            SetRacePerk("Breath Weapon","You can use your action to exhale destructive energy. Your draconic ancestry determines the size, shape, and damage type of the exhalation. When you use your breath weapon, each creature in the area of the exhalation must make a saving throw, the type of which is determined by your draconic ancestry. The DC for this saving throw equals 8 + your Constitution modifier + your proficiency bonus. A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increases to 3d6 at 6th level, 4d6 at 11th level, and 5d6 at 16th level. After you use your breath weapon, you can’t use it again until you complete a short or long rest.");
                        
            SetRacePerk("Damage Resistance","You have resistance to the damage type associated with your draconic ancestry.");
            var DraconicAncestryDamageType = "Damage Resistance (" + GetDraconicAncestry().DamageType +")";
            FeaturesToAdd.Add(new Feature(DraconicAncestryDamageType,"You have resistance to the damage type",1));
            
            SetRacePerk("languages","You can speak, read, and write Common and Draconic. Draconic is thought to be one of the oldest languages and is often used in the study of magic. The language sounds harsh to most other creatures and includes numerous hard consonants and sibilants.");
            AddLanguage("common");
            AddLanguage("draconic");
        }
    }
    public class Dwarf : GenericRace
    {
        public Dwarf()
        {
            SetName("dwarf");

            SetRacePerk("ability score increase", "Your Constitution score increases by 2.");
            SetAbilityScoreIncrease("con", 2);

            SetRacePerk("age", "Dwarves mature at the same rate as humans, but they’re considered young until they reach the age of 50. On average, they live about 350 years.");
            SetAge(Tools.GetRandomNumberInRange(50,350));

            SetRacePerk("alignment","Most dwarves are lawful, believing firmly in the benefits of a well-­‐‑ordered society. They tend toward good as well, with a strong sense of fair play and a belief that everyone deserves to share in the benefits of a just order.");
            
            List<KeyValuePair<string, float>> weightedAlignments = new List<KeyValuePair<string, float>>()
                {
                    new KeyValuePair<string, float>("lawful good",0.5f),
                    new KeyValuePair<string, float>("neutral good",0.0f),
                    new KeyValuePair<string, float>("chaotic good",0.0f),
                    new KeyValuePair<string, float>("lawful neutral",0.3f),
                    new KeyValuePair<string, float>("true neutral",0.0f),
                    new KeyValuePair<string, float>("chaotic neutral",0.0f),
                    new KeyValuePair<string, float>("lawful evil",0.2f),
                    new KeyValuePair<string, float>("neutral evil",0.0f),
                    new KeyValuePair<string, float>("chaotic evil",0.0f),
                };

            SetAlignment(weightedAlignments);

            SetRacePerk("size", "Dwarves stand between 4 and 5 feet tall and average about 150 pounds. Your size is Medium.");
            SetSize("medium");

            SetRacePerk("speed", "Your base walking speed is 25 feet. Your speed is not reduced by wearing heavy armor.");
            SetSpeed(25);

            SetRacePerk("darkvision", "Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray.");
            FeaturesToAdd.Add(new Feature("darkvision", "Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray.",1));
            
            SetRacePerk("dwarven resilience","You have advantage on saving throws against poison, and you have resistance against poison damage.");
            FeaturesToAdd.Add(new Feature("Dwarven Resilience","You have advantage on saving throws against poison, and you have resistance against poison damage.",1));

            SetRacePerk("dwarven combat training","You have proficiency with the battleaxe, handaxe, light hammer, and warhammer.");
            AddRaceProficiency(new List<string>(){"Battleaxe","Light Hammer", "Warhammer"},"weapon");

            SetRacePerk("tool proficiency", "You gain proficiency with the artisan’s tools of your choice: smith’s tools, brewer’s supplies, or mason’s tools.");
            var ArtisansToolList = new List<ArtisansTools>();
            ArtisansToolList.Add(new Equipment().ReturnArtisansToolList().artisansTools.Where(t => t.Name == "Smith’s Tools").ToList()[0]);
            ArtisansToolList.Add(new Equipment().ReturnArtisansToolList().artisansTools.Where(t => t.Name == "Brewer’s Supplies").ToList()[0]);
            ArtisansToolList.Add(new Equipment().ReturnArtisansToolList().artisansTools.Where(t => t.Name == "Mason’s Tools").ToList()[0]);
            ArtisansToolList = Tools.ShuffleList(ArtisansToolList);
            AddRaceProficiency(ArtisansToolList[0].Name,"tool");

            SetRacePerk("stonecunning","Whenever you make an Intelligence (History) check related to the origin of stonework, you are considered proficient in the History skill and add double your proficiency bonus to the check, instead of your normal proficiency bonus.");
            FeaturesToAdd.Add(new Feature("Stonecunning","Whenever you make an Intelligence (History) check related to the origin of stonework, you are considered proficient in the History skill and add double your proficiency bonus to the check, instead of your normal proficiency bonus.",1));
            
            SetRacePerk("languages","You can speak, read, and write Common and Dwarvish. Dwarvish is full of hard consonants and guttural sounds, and those characteristics spill over into whatever other language a dwarf might speak.");
            AddLanguage("common");
            AddLanguage("Dwarvish");

            SetSubRace("hill dwarf");
            SetRacePerk("ability score increase (Hill Dwarf)", "Your Wisdom score increases by 1.");
            SetAbilityScoreIncrease("wis", 1);
            // This gets added in SetLevel1HitPoints()
            SetRacePerk("Dwarven Toughness", "Your hit point maximum increases by 1, and it increases by 1 every time you gain a level.");
            
        }
    }
    public class Elf : GenericRace
    {
        public Elf()
        {
            SetName("elf");

            SetRacePerk("ability score increase", "ability score increase. Your Dexterity score increases by 2.");
            SetAbilityScoreIncrease("dex", 2);

            SetRacePerk("age"," Although elves reach physical maturity at about the same age as humans, the elven understanding of adulthood goes beyond physical growth to encompass worldly experience. An elf typically claims adulthood and an adult name around the age of 100 and can live to be 750 years old.");
            SetAge(Tools.GetRandomNumberInRange(100,750));

            SetRacePerk("alignment","Elves love freedom, variety, and self-expression, so they lean strongly toward the gentler aspects of chaos. They value and protect others’ freedom as well as their own, and they are more often good than not. The drow are an exception; their exile has made them vicious and dangerous. Drow are more often evil than not.");
            
            List<KeyValuePair<string, float>> weightedAlignments = new List<KeyValuePair<string, float>>()
                {
                    new KeyValuePair<string, float>("lawful good",0.1f),
                    new KeyValuePair<string, float>("neutral good",0.1f),
                    new KeyValuePair<string, float>("chaotic good",0.3f),
                    new KeyValuePair<string, float>("lawful neutral",0.0f),
                    new KeyValuePair<string, float>("true neutral",0.1f),
                    new KeyValuePair<string, float>("chaotic neutral",0.3f),
                    new KeyValuePair<string, float>("lawful evil",0.0f),
                    new KeyValuePair<string, float>("neutral evil",0.0f),
                    new KeyValuePair<string, float>("chaotic evil",0.1f),
                };
            
            SetAlignment(weightedAlignments);
            weightedAlignments = null;
            
            SetRacePerk("size","Elves range from under 5 to over 6 feet tall and have slender builds. Your size is Medium.");
            SetSize("medium");

            SetRacePerk("speed","Your base walking speed is 30 feet.");
            SetSpeed(30);

            FeaturesToAdd.Add(new Feature("darkvision", "Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray.",1));

            //TODO Add logic to include additional proficiency
            FeaturesToAdd.Add(new Feature("Keen Senses","You have proficiency in the Perception skill.",1));
            AddRaceProficiency("perception","skill");

            FeaturesToAdd.Add(new Feature("Fey Ancestry","You have advantage on saving throws against being charmed, and magic can’t put you to sleep.",1));
            FeaturesToAdd.Add(new Feature("Trance","Elves don’t need to sleep. Instead, they meditate deeply, remaining semiconscious, for 4 hours a day. (The Common word for such meditation is \"trance.\") While meditating, you can dream after a fashion; such dreams are actually mental exercises that have become reflexive through years of practice. After resting in this way, you gain the same benefit that a human does from 8 hours of sleep.",1));
            
            SetRacePerk("languages","You can speak, read, and write Common and Elvish. Elvish is fluid, with subtle intonations and intricate grammar. Elven literature is rich and varied, and their songs and poems are famous among other races. Many bards learn their language so they can add Elvish ballads to their repertoires.");
            AddLanguage("common");
            AddLanguage("elvish");

            SetSubRace("high elf");
            SetRacePerk("ability score increase (High Elf)","Your Intelligence score increases by 1.");
            SetAbilityScoreIncrease("int", 1);

            //TODO Add logic to include additional proficiency
            SetRacePerk("elf weapon training","You have proficiency with the longswords, shortsword, shortbow, and longbow.");
            AddRaceProficiency(new List<string>(){"Longswords","Shortsword", "Shortbow", "Longbow"},"weapon");

            SetRacePerk("cantrip","You know one cantrip of your choice from the wizard spell list. Intelligence is your spellcasting ability for it.");

            List<string> wizardCantrips = new List<string>()
            {
                "acid splash",
                "chill touch",
                "dancing lights",
                "fire bolt",
                "light",
                "mage hand",
                "mending",
                "message",
                "minor illusion",
                "poison spray",
                "prestidigitation",
                "ray of frost",
                "shocking grasp",
                "true strike"
            };

            // Grabs a random element from the wizard cantrip list above
            SpellsToAdd.Add(wizardCantrips[new Random().Next(0, wizardCantrips.Count)]);

            SetRacePerk("extra language","You can speak, read, and write one extra language of your choice.");
            AddLanguage();
;        }
    }

    public class Gnome : GenericRace
    {
        public Gnome()
        {
            SetName("gnome");

            SetRacePerk("ability score increase","Your Intelligence score increases by 2.");
            SetAbilityScoreIncrease("int", 2 );

            SetRacePerk("age","Gnomes mature at the same rate humans do, and most are expected to settle down into an adult life by around age 40. They can live 350 to almost 500 years.");
            SetAge(Tools.GetRandomNumberInRange(40,500));

            SetRacePerk("alignment","Gnomes are most often good. Those who tend toward law are sages, engineers, researchers, scholars, investigators, or inventors. Those who tend toward chaos are minstrels, tricksters, wanderers, or fanciful jewelers. Gnomes are good-hearted, and even the tricksters among them are more playful than vicious.");
            
            List<KeyValuePair<string, float>> weightedAlignments = new List<KeyValuePair<string, float>>()
                {
                    new KeyValuePair<string, float>("lawful good",0.2f),
                    new KeyValuePair<string, float>("neutral good",0.0f),
                    new KeyValuePair<string, float>("chaotic good",0.2f),
                    new KeyValuePair<string, float>("lawful neutral",0.2f),
                    new KeyValuePair<string, float>("true neutral",0.0f),
                    new KeyValuePair<string, float>("chaotic neutral",0.2f),
                    new KeyValuePair<string, float>("lawful evil",0.1f),
                    new KeyValuePair<string, float>("neutral evil",0.0f),
                    new KeyValuePair<string, float>("chaotic evil",0.1f),
                };
            
            SetAlignment(weightedAlignments);

            SetRacePerk("size","Gnomes are between 3 and 4 feet tall and average about 40 pounds. Your size is Small.");
            SetSize("small");

            SetRacePerk("speed","Your base walking speed is 25 feet");
            SetSpeed(25);

            SetRacePerk("darkvision","Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray.");
            FeaturesToAdd.Add(new Feature("darkvision", "Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray.",1));

            SetRacePerk("gnome cunning","You have advantage on all Intelligence, Wisdom, and Charisma saving throws against magic.");

            SetRacePerk("languages","You can speak, read, and write Common and Gnomish. The Gnomish language, which uses the Dwarvish script, is renowned for its technical treatises and its catalogs of knowledge about the natural world.");
            AddLanguage("common");
            AddLanguage("gnomish");

            SetSubRace("rock gnome");
            SetRacePerk("ability score increase (Rock Gnome)","Your Constitution score increases by 1.");
            SetAbilityScoreIncrease("con", 1);
            SetRacePerk("artificer’s lore","Whenever you make an Intelligence (History) check related to magic items, alchemical objects, or technological devices, you can add twice your proficiency bonus, instead of any proficiency bonus you normally apply.");
            SetRacePerk("tinker","You have proficiency with artisan’s tools (tinker’s tools). Using those tools, you can spend 1 hour and 10 gp worth of materials to construct a Tiny clockwork device (AC 5, 1 hp). The device ceases to function after 24 hours (unless you spend 1 hour repairing it to keep the device functioning), or when you use your action to dismantle it; at that time, you can reclaim the materials used to create it. You can have up to three such devices active at a time. When you create a device, choose one of the following options:");
            AddRaceProficiency("tinker’s tools","tool");
        }
    }
    public class HalfElf : GenericRace
    {
        public HalfElf()
        {
            SetName("half-elf");

            SetRacePerk("ability score increase","Your Charisma score increases by 2, and two other ability scores of your choice increase by 1.");
            SetAbilityScoreIncrease("cha", 2);
            
            //TODO this is shit but I'm tired, refactor
            var remainingAbilities = new List<string>(){"str", "dex", "con", "int", "wis"};

            var index = 0;

            for (var i = 0; i <= 1; i++)
            {
                // Grabs an ability score at a random index
                index = new Random().Next(0,remainingAbilities.Count);
                // Notes the increase
                SetAbilityScoreIncrease(remainingAbilities[index],1);
                // Removes previously picked ability score from list
                // as it shouldn't be picked again
                remainingAbilities.Remove(remainingAbilities[index]);
            }

            SetRacePerk("age","Half-elves mature at the same rate humans do and reach adulthood around the age of 20. They live much longer than humans, however, often exceeding 180 years.");
            SetAge(Tools.GetRandomNumberInRange(20,180));

            SetRacePerk("alignment","Half-elves share the chaotic bent of their elven heritage. They value both personal freedom and creative expression, demonstrating neither love of leaders nor desire for followers. They chafe at rules, resent others’ demands, and sometimes prove unreliable, or at least unpredictable.");
            
            List<KeyValuePair<string, float>> weightedAlignments = new List<KeyValuePair<string, float>>()
                {
                    new KeyValuePair<string, float>("lawful good",0.0f),
                    new KeyValuePair<string, float>("neutral good",0.1f),
                    new KeyValuePair<string, float>("chaotic good",0.2f),
                    new KeyValuePair<string, float>("lawful neutral",0.1f),
                    new KeyValuePair<string, float>("true neutral",0.1f),
                    new KeyValuePair<string, float>("chaotic neutral",0.2f),
                    new KeyValuePair<string, float>("lawful evil",0.0f),
                    new KeyValuePair<string, float>("neutral evil",0.1f),
                    new KeyValuePair<string, float>("chaotic evil",0.2f),
                };
            
            SetAlignment(weightedAlignments);

            SetRacePerk("size","Half-elves are about the same size as humans, ranging from 5 to 6 feet tall. Your size is Medium.");
            SetSize("medium");

            SetRacePerk("speed","Your base walking speed is 30 feet.");
            SetSpeed(30);

            SetRacePerk("darkvision","Thanks to your elf blood, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray.");
            FeaturesToAdd.Add(new Feature("darkvision", "Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray.",1));

            SetRacePerk("Fey Ancestry","You have advantage on saving throws against being charmed, and magic can’t put you to sleep.");
            //TODO Add logic to include additional proficiencies
            SetRacePerk("skill versatility","You gain proficiency in two skills of your choice.");

            List<string> skills = new List<string>()
            {
                "athletics",
                "acrobatics",
                "sleight of hand",
                "arcana",
                "stealth",
                "history",
                "nature",
                "religion",
                "animal handling",
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

            skills = Tools.ShuffleList(skills);
            AddRaceProficiency(skills[0],"skill");
            AddRaceProficiency(skills[1],"skill");

            SetRacePerk("languages","You can speak, read, and write Common, Elvish, and one extra language of your choice.");
            AddLanguage("common");
            AddLanguage("elvish");
            AddLanguage();
        }
        

    }
    public class HalfOrc : GenericRace
    {
        public HalfOrc()
        {
            SetName("half-orc");

            SetRacePerk("ability score increase", "Your Strength score increases by 2, and your Constitution score increases by 1.");
            SetAbilityScoreIncrease("str", 2);
            SetAbilityScoreIncrease("con", 1);

            SetRacePerk("age", "Half-orcs mature a little faster than humans, reaching adulthood around age 14. They age noticeably faster and rarely live longer than 75 years.");
            SetAge(Tools.GetRandomNumberInRange(14, 75));

            SetRacePerk("alignment", "Half-orcs inherit a tendency toward chaos from their orc parents and are not strongly inclined toward good. Half-orcs raised among orcs and willing to live out their lives among them are usually evil.");
            
            List<KeyValuePair<string, float>> weightedAlignments = new List<KeyValuePair<string, float>>()
                {
                    new KeyValuePair<string, float>("lawful good",0.0f),
                    new KeyValuePair<string, float>("neutral good",0.0f),
                    new KeyValuePair<string, float>("chaotic good",0.2f),
                    new KeyValuePair<string, float>("lawful neutral",0.0f),
                    new KeyValuePair<string, float>("true neutral",0.0f),
                    new KeyValuePair<string, float>("chaotic neutral",0.2f),
                    new KeyValuePair<string, float>("lawful evil",0.1f),
                    new KeyValuePair<string, float>("neutral evil",0.1f),
                    new KeyValuePair<string, float>("chaotic evil",0.4f),
                };
            
            SetAlignment(weightedAlignments);

            SetRacePerk("size", "Half-orcs are somewhat larger and bulkier than humans, and they range from 5 to well over 6 feet tall. Your size is Medium.");
            SetSize("medium");

            SetRacePerk("speed", "Your base walking speed is 30 feet.");
            SetSpeed(30);

            SetRacePerk("darkvision", "Thanks to your orc blood, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray.");
            FeaturesToAdd.Add(new Feature("darkvision", "Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray.",1));

            SetRacePerk("menacing", "You gain proficiency in the Intimidation skill.");
            AddRaceProficiency("intimidation", "skill");

            SetRacePerk("relentless endurance","When you are reduced to 0 hit points but not killed outright, you can drop to 1 hit point instead. You can’t use this feature again until you finish a long rest.");

            SetRacePerk("savage attacks"," When you score a critical hit with a melee weapon attack, you can roll one of the weapon’s damage dice one additional time and add it to the extra damage of the critical hit.");

            SetRacePerk("languages","You can speak, read, and write Common and Orc. Orc is a harsh, grating language with hard consonants. It has no script of its own but is written in the Dwarvish script.");
            AddLanguage("common");
            AddLanguage("Orc");
        }
        

    }
    public class Halfling : GenericRace
    {
        public Halfling()
        {
            SetName("halfling");

            SetRacePerk("ability score increase", "Your Dexterity score increases by 2.");
            SetAbilityScoreIncrease("dex",2);

            SetRacePerk("age", "A halfling reaches adulthood at the age of 20 and generally lives into the middle of his or her second century.");
            SetAge(Tools.GetRandomNumberInRange(20,250));

            SetRacePerk("alignment", "Most halflings are lawful good. As a rule, they are good-hearted and kind, hate to see others in pain, and have no tolerance for oppression. They are also very orderly and traditional, leaning heavily on the support of their community and the comfort of their old ways.");
            
            List<KeyValuePair<string, float>> weightedAlignments = new List<KeyValuePair<string, float>>()
                {
                    new KeyValuePair<string, float>("lawful good",0.6f),
                    new KeyValuePair<string, float>("neutral good",0.1f),
                    new KeyValuePair<string, float>("chaotic good",0.1f),
                    new KeyValuePair<string, float>("lawful neutral",0.0f),
                    new KeyValuePair<string, float>("true neutral",0.0f),
                    new KeyValuePair<string, float>("chaotic neutral",0.1f),
                    new KeyValuePair<string, float>("lawful evil",0.0f),
                    new KeyValuePair<string, float>("neutral evil",0.0f),
                    new KeyValuePair<string, float>("chaotic evil",0.1f),
                };
            
            SetAlignment(weightedAlignments);

            SetRacePerk("size", "Halflings average about 3 feet tall and weigh about 40 pounds. Your size is Small.");
            SetSize("small");

            SetRacePerk("speed", "Your base walking speed is 25 feet.");
            SetSpeed(25);

            SetRacePerk("Lucky", "When you roll a 1 on the d20 for an attack roll, ability check, or saving throw, you can reroll the die and must use the new roll.");

            SetRacePerk("Brave", "You have advantage on saving throws against being frightened.");

            SetRacePerk("Halfling Nimbleness", "You can move through the space of any creature that is of a size larger than yours.");

            SetRacePerk("languages","You can speak, read, and write Common and Halfling. The Halfling language isn’t secret, but halflings are loath to share it with others. They write very little, so they don’t have a rich body of literature. Their oral tradition, however, is very strong. Almost all halflings speak Common to converse with the people in whose lands they dwell or through which they are traveling.");
            AddLanguage("common");
            AddLanguage("halfling");

            SetSubRace("lightfoot");
            SetRacePerk("ability score increase (Lightfoot)", "Your Charisma score increases by 1.");
            SetAbilityScoreIncrease("cha", 1);

            SetRacePerk("Naturally Stealthy", "You can attempt to hide even when you are obscured only by a creature that is at least one size larger than you.");
        }
    }
    public class Tiefling : GenericRace
    {
        public Tiefling()
        {
            SetName("tiefling");

            SetRacePerk("ability score increase", "Your Intelligence score increases by 1, and your Charisma score increases by 2.");
            SetAbilityScoreIncrease("int", 1);
            SetAbilityScoreIncrease("cha", 2);

            SetRacePerk("age", "Tieflings mature at the same rate as humans but live a few years longer.");
            SetAge(Tools.GetRandomNumberInRange(18,70));

            SetRacePerk("alignment", " Tieflings might not have an innate tendency toward evil, but many of them end up there. Evil or not, an independent nature inclines many tieflings toward a chaotic alignment.");
            
            List<KeyValuePair<string, float>> weightedAlignments = new List<KeyValuePair<string, float>>()
                {
                    new KeyValuePair<string, float>("lawful good",0.0f),
                    new KeyValuePair<string, float>("neutral good",0.1f),
                    new KeyValuePair<string, float>("chaotic good",0.1f),
                    new KeyValuePair<string, float>("lawful neutral",0.0f),
                    new KeyValuePair<string, float>("true neutral",0.1f),
                    new KeyValuePair<string, float>("chaotic neutral",0.1f),
                    new KeyValuePair<string, float>("lawful evil",0.1f),
                    new KeyValuePair<string, float>("neutral evil",0.1f),
                    new KeyValuePair<string, float>("chaotic evil",0.4f),
                };
            
            SetAlignment(weightedAlignments);

            SetRacePerk("size", "Tieflings are about the same size and build as humans. Your size is Medium.");
            SetSize("medium");

            SetRacePerk("speed", "Your base walking speed is 30 feet.");
            SetSpeed(30);

            SetRacePerk("darkvision", "Thanks to your infernal heritage, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray.");
            FeaturesToAdd.Add(new Feature("darkvision", "Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray.",1));

            SetRacePerk("hellish resistance", "You have resistance to fire damage.");
            FeaturesToAdd.Add(new Feature("Hellish Resistance", "You have resistance to fire damage.",1));

            SetRacePerk("infernal legacy", "You know the thaumaturgy cantrip. When you reach 3rd level, you can cast the hellish rebuke spell as a 2nd-level spell once with this trait and regain the ability to do so when you finish a long rest. When you reach 5th level, you can cast the darkness spell once with this trait and regain the ability to do so when you finish a long rest. Charisma is your spellcasting ability for these spells.");
            SpellsToAdd.Add("Thaumaturgy");

            SetRacePerk("languages", "You can speak, read, and write Common and Infernal.");
            AddLanguage("common");
            AddLanguage("infernal");
        }
    }

    public class RaceLists 
    {
        public GenericRace GetRandomRace()
        {
            switch (Tools.GetRandomNumberInRange(1,9))
            {
                default: throw new Exception("race not found");
                case 1: return new Dwarf(); 
                case 2: return new Dragonborn(); 
                case 3: return new Elf(); 
                case 4: return new Gnome(); 
                case 5: return new HalfElf(); 
                case 6: return new HalfOrc(); 
                case 7: return new Halfling(); 
                case 8: return new Human(); 
                case 9: return new Tiefling(); 
            }
        }
    }
}