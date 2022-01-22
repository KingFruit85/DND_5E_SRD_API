using DND_5E_SRD_API.Models;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DND_5E_SRD_API_TESTS
{
    public class BarbarianTests
    {
        [Fact]
        public void IsInFactABarbarian()
        {
            Character testCharacter = new Character("Barbarian");
            string expected = "Barbarian";
            Assert.Equal(testCharacter.ClassDetails.Name, expected);
        }

        [Fact]
        public void HitPointsAreWithinCorrectRange()
        {
            Character testCharacter = new Character("Barbarian");
            int low = 12;
            int high = 17;
            Assert.InRange(testCharacter.HitPoints, low, high);
        }

        [Fact]
        public void HasTheCorrectArmorProficiencies()
        {
            Character testCharacter = new Character("Barbarian");
            List<string> actual = new List<string>() { "Light Armor", "Medium Armor", "Shields" };
            testCharacter.ClassDetails.Proficiencies["Armor"].Should().BeEquivalentTo(actual);
        }

        [Fact]
        public void HasTheCorrectWeaponProficiencies()
        {
            Character testCharacter = new Character("Barbarian");
            List<string> actual = new List<string>() { "Simple Weapons", "Martial Weapons" };
            testCharacter.ClassDetails.Proficiencies["Weapons"].Should().BeEquivalentTo(actual);
        }

        [Fact]
        public void HasTheCorrectToolProficiencies()
        {
            Character testCharacter = new Character("Barbarian");
            List<string> actual = new List<string>() { };
            testCharacter.ClassDetails.Proficiencies["Tools"].Should().BeEquivalentTo(actual);
        }

        [Fact]
        public void HasTheCorrectSavingThrowProficiencies()
        {
            Character testCharacter = new Character("Barbarian");
            List<string> actual = new List<string>() { "Strength", "Constitution" };
            testCharacter.ClassDetails.Proficiencies["Saving Throws"].Should().BeEquivalentTo(actual);
        }

        [Fact]
        public void HasTheCorrectNumberOfSkillProficiencies()
        {
            Character testCharacter = new Character("Barbarian");
            testCharacter.ClassDetails.Proficiencies["Saving Throws"].Should().HaveCount(2);
        }

    }
}
