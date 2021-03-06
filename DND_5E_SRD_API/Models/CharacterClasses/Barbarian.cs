using DND_5E_SRD_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DND_5E_SRD_API.Controllers
{
    public class Barbarian : GenericCharacterClass
    {
        public Barbarian()
        {
            SetName("barbarian");
            SetProficiencyBonus(2);
            HitDie = "1d12";

            // Populate Proficiencies
            var Proficiencies = new Dictionary<string,List<string>>()
            {
                {"armor", new List<string>(){"Light Armor", "Medium Armor", "Shields"}},
                {"weapons",new List<string>(){"Simple Weapons", "Martial Weapons"}},
                {"tools", new List<string>()},
                {"saving throws", new List<string>(){"Strength", "Constitution"}},
                {"skills", new List<string>(){}}
            };

            // Barbarians can select two skills from the following list
            var barbSkillProfs = new List<string>()
            {
                "animal handling",
                "athletics",
                "intimidation",
                "nature",
                "perception",
                "survival"
            };
            // Shuffle list and add the top two
            barbSkillProfs = Tools.ShuffleList(barbSkillProfs);
            Proficiencies["skills"].Add(barbSkillProfs[0]);
            Proficiencies["skills"].Add(barbSkillProfs[1]);

            SetProficiencies(Proficiencies);

            // Barbarians start with with a greataxe or any martial melee weapon
            switch (new Random().Next(0,1))
            {
                default: throw new Exception("invalid option");
                case 0:
                    PrimaryWeapon = GetWeapons().Where(w => w.Name == "Greataxe").ToList()[0];
                    break;
                case 1:
                    var MartialMeleeWeapons = GetWeapons().Where(w => w.WeaponType == "Martial Melee").ToList();
                    MartialMeleeWeapons = Tools.ShuffleList(MartialMeleeWeapons);
                    PrimaryWeapon = MartialMeleeWeapons[0];
                    break;
            }

            // Barbarians start also start with either 2 x handaxes or any simple weapon
            switch (Tools.GetRandomNumberInRange(0,1))
            {
                default: throw new Exception("number not in range");
                case 0:
                    // Add Simple Weapon
                    var simpleWeaponList = GetWeapons().Where(w => w.WeaponType == "Simple Melee").ToList();
                    Tools.ShuffleList(simpleWeaponList);
                    var randomWeapon = simpleWeaponList[0];
                    AdditionalWeapons.Add(randomWeapon);
                    break;
                case 1: 
                    // Add 2xHand axes
                    for (int i = 0; i < 1; i++)
                    {
                        AdditionalWeapons.Add(GetWeapons().Where(w => w.Name == "Handaxe").ToList()[0]);
                    }
                    break;
            }

            // barbarians also start with an explorers pack and 4 x javelin
            EquipmentPack = GetPacks().Where(p => p.Name == "Explorer's Pack").ToList()[0];

            for (int i = 0; i <= 3; i++)
            {
                AdditionalWeapons.Add(GetWeapons().Where(w => w.Name == "Javelin").ToList()[0]);
            }

            // Add Barbarian features
            Features.Add(new Feature("Rage","",1));
            Features.Add(new Feature("Unarmored Defense","",1));

        }
    }
}