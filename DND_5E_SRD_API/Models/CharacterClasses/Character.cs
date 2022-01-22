using DND_5E_SRD_API.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DND_5E_SRD_API.Models
{
    public class Character
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CharacterClass { get; set; }
        public string Gender { get; set; }
        public int HitPoints { get; set; }
        public int ArmorClass { get; set; }
        public int Initiative { get; set; }
        public GenericRace RaceDetails { get; set; }
        public AbilityScores AbilityScores { get; set; }
        public GenericCharacterClass ClassDetails { get; set; }
        public Dictionary<string, int> Skills { get; set; }
        public Dictionary<string, int> SavingThrows { get; set; }

        // Getters & Setters
        public void SetRace(GenericRace race) { RaceDetails = race; }
        public GenericRace GetRace() { return RaceDetails; }
        public string GetFirstName() { return FirstName; }
        public void SetFirstName(string name) { FirstName = name; }
        public string GetLastName() { return LastName; }
        public void SetLastName(string name) { LastName = name; }
        public string GetCharacterClass() { return CharacterClass; }
        public void SetCharacterClass(string className) { CharacterClass = className; }
        public string GetGender() { return Gender; }
        public void SetGender(string gender) { Gender = gender; }

        public AbilityScores GetAbilityScores()
        {
            return AbilityScores;
        }

        public AbilityScores GetAbilityScores(string score)
        {
            return AbilityScores;
        }
        public void SetAbilityScore(AbilityScores abilityScore)
        {
            AbilityScores = abilityScore;
        }

        public string SetRandomGender()
        {
            int i = new Random().Next(1, 100);

            if (i >= 1 && i <= 39) return "Male";
            if (i >= 40 && i <= 79) return "Female";
            else return "Non-Binary";
        }

        public GenericRace SetRandomRace()
        {
            return new RaceLists().GetRandomRace();
        }

        public string GetRandomFirstName(string gender, string race)
        {
            return new NameLists().GetRandomName(gender, race)[0];
        }


        public string GetRandomLastName(string gender, string race)
        {
            return new NameLists().GetRandomName(gender, race)[1];
        }

        public void UpdateAbilityScores()
        {
            // Grab the the scores to be added
            var ASU = GetRace().GetAbilityScoreIncrease();

            // Update the characters abilityscores
            foreach (var stat in ASU)
            {
                GetAbilityScores().SetScore(stat.Key, stat.Value);
            }
        }

        public void AddRacialProficiencies()
        {
            var skills = RaceDetails.RaceSkillProficienciesToAdd;
            var weapons = RaceDetails.RaceWeaponProficienciesToAdd;
            var armors = RaceDetails.RaceArmorProficienciesToAdd;
            var tools = RaceDetails.RaceToolProficienciesToAdd;

            if (skills.Count > 0)
            {
                foreach (var skill in skills)
                {
                    if (!ClassDetails.Proficiencies["Skills"].Contains(skill))
                    {
                        ClassDetails.Proficiencies["Skills"].Add(skill);
                    }
                }
            }

            if (weapons.Count > 0)
            {
                foreach (var weapon in weapons)
                {
                    if (!ClassDetails.Proficiencies["Weapons"].Contains(weapon))
                    {
                        ClassDetails.Proficiencies["Weapons"].Add(weapon);
                    }
                }
            }

            if (armors.Count > 0)
            {
                foreach (var armor in armors)
                {
                    if (!ClassDetails.Proficiencies["Armor"].Contains(armor))
                    {
                        ClassDetails.Proficiencies["Weapons"].Add(armor);
                    }
                }
            }

            if (tools.Count > 0)
            {
                foreach (var armor in armors)
                {
                    if (!ClassDetails.Proficiencies["Armor"].Contains(armor))
                    {
                        ClassDetails.Proficiencies["Weapons"].Add(armor);
                    }
                }
            }
        }

        public void AddRacialSpells()
        {
            var spells = RaceDetails.SpellsToAdd;
            List<Spells> actualSpells = new List<Spells>();

            if (spells.Count > 0)
            {
                foreach (var spell in spells)
                {
                    actualSpells.Add(Tools.ReturnSpecificSpell(spell));
                }
            }

            foreach (var spell in actualSpells)
            {

                if (spell.level == 0 && !ClassDetails.Cantrips.Contains(spell))
                {
                    ClassDetails.Cantrips.Add(spell);
                }

                if (spell.level == 1 && !ClassDetails.Level1Spells.Contains(spell))
                {
                    ClassDetails.Level1Spells.Add(spell);
                }

            }
        }

        public void SetSkillsAndSavingThrows()
        {
            // SKILLS
            var Intelligence = (int)AbilityScores.getAbilityScoreModifier(AbilityScores.GetIntelligenceScore());
            var Strength = (int)AbilityScores.getAbilityScoreModifier(AbilityScores.GetStrengthScore());
            var Constitution = (int)AbilityScores.getAbilityScoreModifier(AbilityScores.GetConstitutionScore());
            var Dexterity = (int)AbilityScores.getAbilityScoreModifier(AbilityScores.GetDexterityScore());
            var Wisdom = (int)AbilityScores.getAbilityScoreModifier(AbilityScores.GetWisdomScore());
            var Charisma = (int)AbilityScores.getAbilityScoreModifier(AbilityScores.GetCharismaScore());

            var skillAndMods = new Dictionary<string, int>();

            skillAndMods["athletics"] = Strength;
            skillAndMods["acrobatics"] = Dexterity;
            skillAndMods["sleightOfHand"] = Dexterity;
            skillAndMods["arcana"] = Intelligence;
            skillAndMods["stealth"] = Dexterity;
            skillAndMods["history"] = Intelligence;
            skillAndMods["nature"] = Intelligence;
            skillAndMods["religion"] = Intelligence;
            skillAndMods["animalHandling"] = Wisdom;
            skillAndMods["insight"] = Wisdom;
            skillAndMods["medicine"] = Wisdom;
            skillAndMods["perception"] = Wisdom;
            skillAndMods["survival"] = Wisdom;
            skillAndMods["deception"] = Charisma;
            skillAndMods["intimidation"] = Charisma;
            skillAndMods["investigation"] = Intelligence;
            skillAndMods["performance"] = Charisma;
            skillAndMods["persuasion"] = Charisma;

            // Add prof bonus 
            var profBonuses = ClassDetails.GetProficiencies()["Skills"];

            foreach (var skill in profBonuses)
            {
                if (skillAndMods.ContainsKey(skill))
                {
                    skillAndMods[skill] += ClassDetails.GetProficiencyBonus();
                }
            }

            Skills = skillAndMods;

            // SAVING THROWS

            var savingThrowProfs = ClassDetails.GetProficiencies()["Saving Throws"];

            var savingThrows = new Dictionary<string, int>()
            {
                {"Strength",Strength},
                {"Dexterity",Dexterity},
                {"Constitution",Constitution},
                {"Intelligence",Intelligence},
                {"Wisdom",Wisdom},
                {"Charisma",Charisma}
            };

            foreach (var savingThrow in savingThrowProfs)
            {
                if (skillAndMods.ContainsKey(savingThrow))
                {
                    savingThrows[savingThrow] += ClassDetails.GetProficiencyBonus();
                }
            }
            SavingThrows = savingThrows;
        }


        public GenericCharacterClass GetSpecificCharacterClass(string characterClass)
        {
            switch (characterClass)
            {
                default: throw new Exception("Unknown Character Class provided as argument");
                case "Bard": return new Bard();
                case "Barbarian": return new Barbarian();
                case "Cleric": return new Cleric(); 
                case "Fighter": return new Fighter(); 
                case "Monk": return new Monk(); 
                case "Paladin": return new Paladin(); 
                case "Ranger": return new Ranger(); 
                case "Rogue": return new Rogue(); 
                case "Sorcerer": return new Sorcerer(); 
                case "Warlock": return new Warlock(); 
                case "Wizard": return new Wizard(); 
                case "Druid": return new Druid(); 
            }
        }

        public void SetLevel1HitPoints()
        {
            var constitutionModifier = (int)AbilityScores.getAbilityScoreModifier(AbilityScores.GetConstitutionScore());

            switch (ClassDetails.Name)
            {
                default: throw new Exception("invalid characterClass provided");
                case "Barbarian": HitPoints = 12 + constitutionModifier; break;
                case "Bard": HitPoints = 8 + constitutionModifier; break;
                case "Cleric": HitPoints = 8 + constitutionModifier; break;
                case "Druid": HitPoints = 8 + constitutionModifier; break;
                case "Fighter": HitPoints = 10 + constitutionModifier; break;
                case "Monk": HitPoints = 8 + constitutionModifier; break;
                case "Paladin": HitPoints = 10 + constitutionModifier; break;
                case "Ranger": HitPoints = 10 + constitutionModifier; break;
                case "Rogue": HitPoints = 8 + constitutionModifier; break;
                case "Sorcerer": HitPoints = 6 + constitutionModifier; break;
                case "Warlock": HitPoints = 8 + constitutionModifier; break;
                case "Wizard": HitPoints = 6 + constitutionModifier; break;
            }

            // The Hill Dwarf subrace hit point maximum increases by 1
            if (this.RaceDetails.SubRace == "Hill Dwarf")
            {
                HitPoints += 1;
            }

            // Sorcerer Draconic Ancestry
            if (this.ClassDetails.SorcerousOrigin == "Draconic")
            {
                HitPoints += 1;
            }

        }

        public void CalculateArmorClass()
        {
            int armorClassValue = ClassDetails.Armor.BaseArmorClass;

            // Check from barbarian/Unarmored Defense
            var isBarbarian = (this.ClassDetails.Name == "Barbarian") ? true : false;
            var isFighter = (this.ClassDetails.Name == "Fighter") ? true : false;
            var isMonk = (this.ClassDetails.Name == "Monk") ? true : false;
            var isSorcerer = (this.ClassDetails.Name == "Sorcerer") ? true : false;
            var isWizard = (this.ClassDetails.Name == "Wizard") ? true : false;

            // This will need to be expanded to take into account the type of shield held at a future date
            var isHoldingShield = (this.ClassDetails.Shield != null);

            if (isBarbarian)
            {
                // TODO: This should check for armor
                ArmorClass = 10
                + (int)AbilityScores.getAbilityScoreModifier("DEX")
                + (int)AbilityScores.getAbilityScoreModifier("CON");
                return;
            }

            if (isFighter)
            {
                // Checks to see if Fighter has Defence fighting style and has armor equipped
                if (this.ClassDetails.FightingStyle == "Defense" && this.ClassDetails.Armor.Name != null)
                {
                    armorClassValue += 1;
                }
            }

            if (isMonk)
            {
                // Double checks to make sure no armor is equipped
                if (this.ClassDetails.Armor.Name == null)
                {
                    ArmorClass = 10
                    + (int)AbilityScores.getAbilityScoreModifier("DEX")
                    + (int)AbilityScores.getAbilityScoreModifier("WIS");
                    return;
                }
            }

            if (isSorcerer)
            {
                // Checks SorcerousOrigin for Draconic
                // Draconic Sorcerous Origin Unarmored AC = 13 + Dex mod
                if (this.ClassDetails.Armor.Name == null)
                {
                    ArmorClass = 13
                    + (int)AbilityScores.getAbilityScoreModifier("DEX");
                    return;
                }
            }

            if (isWizard)
            {
                // Wizards shouldn't start with any armor
                if (this.ClassDetails.Armor.Name == null)
                {
                    ArmorClass = 10
                    + (int)AbilityScores.getAbilityScoreModifier("DEX");
                    return;
                }
            }

            if (isHoldingShield)
            {
                armorClassValue += 2;
            }

            if (ClassDetails.Armor.AdditionalModifier != null)
            {
                var modValue = ClassDetails.Armor.AdditionalModifier;
                var abilityScoreMod = AbilityScores.getAbilityScoreModifier(modValue);
                armorClassValue += (int)abilityScoreMod;
            }
            ArmorClass = armorClassValue;
        }

        public void CalculateInitiative()
        {
            Initiative = (int)AbilityScores.getAbilityScoreModifier("DEX");
        }


        public Character()
        {
            Gender = SetRandomGender();
            RaceDetails = SetRandomRace();
            CharacterClass = new CharacterClass().GetRandomClass();
            FirstName = GetRandomFirstName(Gender,RaceDetails.Name);
            LastName = GetRandomLastName(Gender, RaceDetails.Name);
            AbilityScores = new AbilityScores();
            AbilityScores.Arrange(CharacterClass);
            UpdateAbilityScores();
            ClassDetails = GetSpecificCharacterClass(CharacterClass);
            AddRacialProficiencies();
            AddRacialSpells();
            SetSkillsAndSavingThrows();
            SetLevel1HitPoints();
            CalculateArmorClass();
            CalculateInitiative();

        }
    }
}
