using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DND_5E_SRD_API.Models
{
    public class AbilityScores
    {
        private int[] RawScores = new Dice().ReturnAbilityScores();
        public Dictionary<string, int> scores { get; set; } = new Dictionary<string, int>()
        {
            {"STR",0},
            {"DEX",0},
            {"CON",0},
            {"INT",0},
            {"WIS",0},
            {"CHA",0},
        };

        public void Arrange(string characterClassName)
        {
            switch (characterClassName)
            {
                case "Bard":
                    ArrangeBardScores();
                    break;

                case "Barbarian":
                    ArrangeBarbarianScores();
                    break;

                case "Cleric":
                    ArrangeClericScores();
                    break;

                case "Fighter":
                    ArrangeFighterScores();
                    break;

                case "Monk":
                    ArrangeMonkScores();
                    break;

                case "Paladin":
                    ArrangePaladinScores();
                    break;

                case "Ranger":
                    ArrangeRangerScores();
                    break;

                case "Rogue":
                    ArrangeRogueScores();
                    break;

                case "Sorcerer":
                    ArrangeSorcererScores();
                    break;

                case "Warlock":
                    ArrangeWarlockScores();
                    break;

                case "Wizard":
                    ArrangeWizardScores();
                    break;

                case "Druid":
                    ArrangeDruidScores();
                    break;

                default: throw new Exception("class name wasn't caught");
            }

        }

        public void ArrangeBardScores()
        {
            scores["CHA"] = RawScores[0];
            scores["DEX"] = RawScores[1];
            scores["CON"] = RawScores[2];
            scores["WIS"] = RawScores[3];
            scores["STR"] = RawScores[4];
            scores["INT"] = RawScores[5];
        }

        public void ArrangeBarbarianScores()
        {
            scores["STR"] = RawScores[0];
            scores["CON"] = RawScores[1];
            scores["DEX"] = RawScores[2];
            scores["WIS"] = RawScores[3];
            scores["CHA"] = RawScores[4];
            scores["INT"] = RawScores[5];
        }

        public void ArrangeMonkScores()
        {
            scores["DEX"] = RawScores[0];
            scores["WIS"] = RawScores[1];
            scores["CON"] = RawScores[2];
            scores["STR"] = RawScores[3];
            scores["CHA"] = RawScores[4];
            scores["INT"] = RawScores[5];
        }

        public void ArrangeClericScores()
        {
            scores["WIS"] = RawScores[0];
            scores["STR"] = RawScores[1];
            scores["CON"] = RawScores[2];
            scores["DEX"] = RawScores[3];
            scores["CHA"] = RawScores[4];
            scores["INT"] = RawScores[5];
        }


        public void ArrangeDruidScores()
        {
            scores["WIS"] = RawScores[0];
            scores["DEX"] = RawScores[1];
            scores["CON"] = RawScores[2];
            scores["CHA"] = RawScores[3];
            scores["INT"] = RawScores[4];
            scores["STR"] = RawScores[5];
        }

        public void ArrangePaladinScores()
        {
            scores["STR"] = RawScores[0];
            scores["CHA"] = RawScores[1];
            scores["CON"] = RawScores[2];
            scores["WIS"] = RawScores[3];
            scores["DEX"] = RawScores[4];
            scores["INT"] = RawScores[5];
        }

        public void ArrangeRangerScores()
        {
            scores["DEX"] = RawScores[0];
            scores["CON"] = RawScores[1];
            scores["WIS"] = RawScores[2];
            scores["STR"] = RawScores[3];
            scores["CHA"] = RawScores[4];
            scores["INT"] = RawScores[5];
        }

        public void ArrangeRogueScores()
        {
            scores["DEX"] = RawScores[0];
            scores["CON"] = RawScores[1];
            scores["WIS"] = RawScores[2];
            scores["CHA"] = RawScores[3];
            scores["INT"] = RawScores[4];
            scores["STR"] = RawScores[5];
        }

        public void ArrangeSorcererScores()
        {
            scores["CHA"] = RawScores[0];
            scores["CON"] = RawScores[1];
            scores["INT"] = RawScores[2];
            scores["WIS"] = RawScores[3];
            scores["DEX"] = RawScores[4];
            scores["STR"] = RawScores[5];
        }

        public void ArrangeWarlockScores()
        {
            scores["CHA"] = RawScores[0];
            scores["CON"] = RawScores[1];
            scores["DEX"] = RawScores[2];
            scores["WIS"] = RawScores[3];
            scores["INT"] = RawScores[4];
            scores["STR"] = RawScores[5];
        }

        public void ArrangeWizardScores()
        {
            scores["INT"] = RawScores[0];
            scores["CON"] = RawScores[1];
            scores["DEX"] = RawScores[2];
            scores["WIS"] = RawScores[3];
            scores["CHA"] = RawScores[4];
            scores["STR"] = RawScores[5];
        }

        public void ArrangeFighterScores()
        {
            scores["STR"] = RawScores[0];
            scores["CON"] = RawScores[1];
            scores["DEX"] = RawScores[2];
            scores["WIS"] = RawScores[3];
            scores["CHA"] = RawScores[4];
            scores["INT"] = RawScores[5];
        }

        public int[] GetRawScores()
        {
            return RawScores;
        }

        public void SetStrengthScore(int score)
        {
            scores["STR"] = score;
        }

        public int GetStrengthScore()
        {
            return scores["STR"];
        }

        public void SetDexterityScore(int score)
        {
            scores["DEX"] = score;
        }

        public int GetDexterityScore()
        {
            return scores["DEX"];
        }

        public void SetConstitutionScore(int score)
        {
            scores["CON"] = score;
        }

        public int GetConstitutionScore()
        {
            return scores["CON"];
        }

        public void SetIntelligenceScore(int score)
        {
            scores["INT"] = score;
        }

        public int GetIntelligenceScore()
        {
            return scores["INT"];
        }

        public void SetWisdomScore(int score)
        {
            scores["WIS"] = score;
        }

        public int GetWisdomScore()
        {
            return scores["WIS"];
        }

        public void SetCharismaScore(int score)
        {
            scores["CHA"] = score;
        }

        public int GetCharismaScore()
        {
            return scores["CHA"];
        }

        public double getAbilityScoreModifier(int score)
        {
            return Math.Floor(((double)score - 10) / 2);
        }

        public double getAbilityScoreModifier(string score)
        {
            switch (score)
            {
                default: throw new Exception("A valid ability score string was not provided");
                case "STR": return getAbilityScoreModifier(scores[score]);
                case "DEX": return getAbilityScoreModifier(scores[score]);
                case "CON": return getAbilityScoreModifier(scores[score]);
                case "INT": return getAbilityScoreModifier(scores[score]);
                case "WIS": return getAbilityScoreModifier(scores[score]);
                case "CHA": return getAbilityScoreModifier(scores[score]);
            }
        }

        public void SetScore(string stat, int score)
        {
            switch (stat)
            {
                case "STR":
                    scores["STR"] += score;
                    break;
                case "DEX":
                    scores["DEX"] += score;
                    break;
                case "CON":
                    scores["CON"] += score;
                    break;
                case "WIS":
                    scores["WIS"] += score;
                    break;
                case "INT":
                    scores["INT"] += score;
                    break;
                case "CHA":
                    scores["CHA"] += score;
                    break;

                default: throw new Exception("Unable to increment ability score");
            }

        }
    }
}