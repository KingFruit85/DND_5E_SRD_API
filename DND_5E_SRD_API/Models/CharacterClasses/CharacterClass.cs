using System;
using System.Collections.Generic;

namespace DND_5E_SRD_API.Models
{
    public class CharacterClass
    {
        private List<string> CharacterClasses = new List<string> {"bard", "barbarian", "cleric", "fighter", "monk", "paladin", "ranger",
                                             "rogue", "sorcerer", "warlock", "wizard", "druid"};
        public string GetRandomClass()
        {
            int i = new Random().Next(0, CharacterClasses.Count);
            return CharacterClasses[i];
        }
    }
}
