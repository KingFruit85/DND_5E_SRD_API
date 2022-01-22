using DND_5E_SRD_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DND_5E_SRD_API_TESTS
{
    public class CharacterTests
    {
        [Fact]
        public void CharacterClassIsNotNull()
        {
            // Arrange
            Character testCharacter = new Character();
            // Act

            // Assert
            Assert.NotNull(testCharacter.CharacterClass);
        }

        [Fact]
        public void FirstNameIsNotNull()
        {
            // Arrange
            Character testCharacter = new Character();
            // Act

            // Assert
            Assert.NotNull(testCharacter.FirstName);
        }
        
        [Fact]
        public void LastNameIsNotNull()
        {
            // Arrange
            Character testCharacter = new Character();
            // Act

            // Assert
            Assert.NotNull(testCharacter.LastName);
        }

        [Fact]
        public void AbilityScoresAreNotNull()
        {
            // Arrange
            Character testCharacter = new Character();
            // Act
            
            // Assert
            Assert.True(testCharacter.AbilityScores.scores["STR"] > 0);
            Assert.True(testCharacter.AbilityScores.scores["DEX"] > 0);
            Assert.True(testCharacter.AbilityScores.scores["CON"] > 0);
            Assert.True(testCharacter.AbilityScores.scores["INT"] > 0);
            Assert.True(testCharacter.AbilityScores.scores["WIS"] > 0);
            Assert.True(testCharacter.AbilityScores.scores["CHA"] > 0);
        }
    }
}
