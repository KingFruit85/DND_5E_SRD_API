using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DND_5E_SRD_API.Models
{
    public class CharacterClass
    {
        private List<string> CharacterClasses = new List<string> {"Bard", "Barbarian", "Cleric", "Fighter", "Monk", "Paladin", "Ranger",
                                             "Rogue", "Sorcerer", "Warlock", "Wizard", "Druid"};
        public string GetRandomClass()
        {
            int i = new Random().Next(0, CharacterClasses.Count);
            return CharacterClasses[i];
        }
    }
}
