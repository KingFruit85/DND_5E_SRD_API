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
            int[] rawScores = new int[] { };
            switch (characterClassName)
            {
                case "Bard":
                    ArrangeBardScores(rawScores);
                    break;

                case "Barbarian":
                    ArrangeBarbarianScores(rawScores);
                    break;

                case "Cleric":
                    ArrangeClericScores(rawScores);
                    break;

                case "Fighter":
                    ArrangeFighterScores(rawScores);
                    break;

                case "Monk":
                    ArrangeMonkScores(rawScores);
                    break;

                case "Paladin":
                    ArrangePaladinScores(rawScores);
                    break;

                case "Ranger":
                    ArrangeRangerScores(rawScores);
                    break;

                case "Rogue":
                    ArrangeRogueScores(rawScores);
                    break;

                case "Sorcerer":
                    ArrangeSorcererScores(rawScores);
                    break;

                case "Warlock":
                    ArrangeWarlockScores(rawScores);
                    break;

                case "Wizard":
                    ArrangeWizardScores(rawScores);
                    break;

                case "Druid":
                    ArrangeDruidScores(rawScores);
                    break;

                default: throw new Exception("class name wasn't caught");
            }

        }

        public Dictionary<string, int> Arrange(string characterClassName, int[] rawScores)
        {
            switch (characterClassName)
            {
                case "Bard":return ArrangeBardScores(rawScores);
                case "Barbarian":return ArrangeBarbarianScores(rawScores);
                case "Cleric":return ArrangeClericScores(rawScores);
                case "Fighter":return ArrangeFighterScores(rawScores);
                case "Monk":return ArrangeMonkScores(rawScores);
                case "Paladin":return ArrangePaladinScores(rawScores);
                case "Ranger":return ArrangeRangerScores(rawScores);
                case "Rogue":return ArrangeRogueScores(rawScores);
                case "Sorcerer":return ArrangeSorcererScores(rawScores);
                case "Warlock":return ArrangeWarlockScores(rawScores);
                case "Wizard":return ArrangeWizardScores(rawScores);
                case "Druid":return ArrangeDruidScores(rawScores);
                default: throw new Exception("class name wasn't caught");
            }
        }

        public Dictionary<string, int> ArrangeBardScores(int[] rawScores)
        {
            if (rawScores.Length > 0)
            {
                Dictionary<string, int> _scores = new Dictionary<string, int>()
                {
                    {"CHA",rawScores[0]},
                    {"DEX",rawScores[1]},
                    {"CON",rawScores[2]},
                    {"WIS",rawScores[3]},
                    {"STR",rawScores[4]},
                    {"INT",rawScores[5]},
                };
                return _scores;
            }
            else
            {
                scores["CHA"] = RawScores[0];
                scores["DEX"] = RawScores[1];
                scores["CON"] = RawScores[2];
                scores["WIS"] = RawScores[3];
                scores["STR"] = RawScores[4];
                scores["INT"] = RawScores[5];
                return new Dictionary<string, int>();
            }
        }

        public Dictionary<string, int> ArrangeBarbarianScores(int[] rawScores)
        {
            if (rawScores.Length > 0)
            {
                Dictionary<string, int> _scores = new Dictionary<string, int>()
                {
                    {"STR",rawScores[0]},
                    {"CON",rawScores[1]},
                    {"DEX",rawScores[2]},
                    {"WIS",rawScores[3]},
                    {"CHA",rawScores[4]},
                    {"INT",rawScores[5]},
                };
                return _scores;
            }
            else
            {
                scores["STR"] = RawScores[0];
                scores["CON"] = RawScores[1];
                scores["DEX"] = RawScores[2];
                scores["WIS"] = RawScores[3];
                scores["CHA"] = RawScores[4];
                scores["INT"] = RawScores[5];
                return new Dictionary<string, int>();
            }
        }

        public Dictionary<string, int> ArrangeMonkScores(int[] rawScores)
        {
            if (rawScores.Length > 0)
            {
                Dictionary<string, int> _scores = new Dictionary<string, int>()
                {
                    {"DEX",rawScores[0]},
                    {"WIS",rawScores[1]},
                    {"CON",rawScores[2]},
                    {"STR",rawScores[3]},
                    {"CHA",rawScores[4]},
                    {"INT",rawScores[5]},
                };
                return _scores;
            }
            else
            {
                scores["DEX"] = RawScores[0];
                scores["WIS"] = RawScores[1];
                scores["CON"] = RawScores[2];
                scores["STR"] = RawScores[3];
                scores["CHA"] = RawScores[4];
                scores["INT"] = RawScores[5];
                return new Dictionary<string, int>();
            }
        }

        public Dictionary<string, int> ArrangeClericScores(int[] rawScores)
        {
            if (rawScores.Length > 0)
            {
                Dictionary<string, int> _scores = new Dictionary<string, int>()
                {
                    {"WIS",rawScores[0]},
                    {"STR",rawScores[1]},
                    {"CON",rawScores[2]},
                    {"DEX",rawScores[3]},
                    {"CHA",rawScores[4]},
                    {"INT",rawScores[5]},
                };
                return _scores;
            }
            else
            {
                scores["WIS"] = RawScores[0];
                scores["STR"] = RawScores[1];
                scores["CON"] = RawScores[2];
                scores["DEX"] = RawScores[3];
                scores["CHA"] = RawScores[4];
                scores["INT"] = RawScores[5];
                return new Dictionary<string, int>();
            }
        }


        public Dictionary<string, int> ArrangeDruidScores(int[] rawScores)
        {
            if (rawScores.Length > 0)
            {
                Dictionary<string, int> _scores = new Dictionary<string, int>()
                {
                    {"WIS",rawScores[0]},
                    {"DEX",rawScores[1]},
                    {"CON",rawScores[2]},
                    {"CHA",rawScores[3]},
                    {"INT",rawScores[4]},
                    {"STR",rawScores[5]},
                };
                return _scores;
            }
            else
            {
                scores["WIS"] = RawScores[0];
                scores["DEX"] = RawScores[1];
                scores["CON"] = RawScores[2];
                scores["CHA"] = RawScores[3];
                scores["INT"] = RawScores[4];
                scores["STR"] = RawScores[5];
                return new Dictionary<string, int>();

            }
        }


        public Dictionary<string, int> ArrangePaladinScores(int[] rawScores)
        {
            if (rawScores.Length > 0)
            {
                Dictionary<string, int> _scores = new Dictionary<string, int>()
                {
                    {"WIS",rawScores[0]},
                    {"DEX",rawScores[1]},
                    {"CON",rawScores[2]},
                    {"CHA",rawScores[3]},
                    {"INT",rawScores[4]},
                    {"STR",rawScores[5]},
                };
                return _scores;
            }
            else
            {
                scores["WIS"] = RawScores[0];
                scores["DEX"] = RawScores[1];
                scores["CON"] = RawScores[2];
                scores["CHA"] = RawScores[3];
                scores["INT"] = RawScores[4];
                scores["STR"] = RawScores[5];
                return new Dictionary<string, int>();
            }
        }

        public Dictionary<string, int> ArrangeRangerScores(int[] rawScores)
        {
            if (rawScores.Length > 0)
            {
                Dictionary<string, int> _scores = new Dictionary<string, int>()
                {
                    {"DEX",rawScores[0]},
                    {"CON",rawScores[1]},
                    {"WIS",rawScores[2]},
                    {"STR",rawScores[3]},
                    {"CHA",rawScores[4]},
                    {"INT",rawScores[5]},
                };
                return _scores;
            }
            else
            {
                scores["DEX"] = RawScores[0];
                scores["CON"] = RawScores[1];
                scores["WIS"] = RawScores[2];
                scores["STR"] = RawScores[3];
                scores["CHA"] = RawScores[4];
                scores["INT"] = RawScores[5];
                return new Dictionary<string, int>();
            }
        }

        public Dictionary<string, int> ArrangeRogueScores(int[] rawScores)
        {
            if (rawScores.Length > 0)
            {
                Dictionary<string, int> _scores = new Dictionary<string, int>()
                {
                    {"DEX",rawScores[0]},
                    {"CON",rawScores[1]},
                    {"WIS",rawScores[2]},
                    {"CHA",rawScores[3]},
                    {"INT",rawScores[4]},
                    {"STR",rawScores[5]},
                };
                return _scores;
            }
            else
            {
                scores["DEX"] = RawScores[0];
                scores["CON"] = RawScores[1];
                scores["WIS"] = RawScores[2];
                scores["CHA"] = RawScores[3];
                scores["INT"] = RawScores[4];
                scores["STR"] = RawScores[5];
                return new Dictionary<string, int>();
            }
        }

        public Dictionary<string, int> ArrangeSorcererScores(int[] rawScores)
        {
            if (rawScores.Length > 0)
            {
                Dictionary<string, int> _scores = new Dictionary<string, int>()
                {
                    {"CHA",rawScores[0]},
                    {"CON",rawScores[1]},
                    {"INT",rawScores[2]},
                    {"WIS",rawScores[3]},
                    {"DEX",rawScores[4]},
                    {"STR",rawScores[5]},
                };
                return _scores;
            }
            else
            {
                scores["CHA"] = RawScores[0];
                scores["CON"] = RawScores[1];
                scores["INT"] = RawScores[2];
                scores["WIS"] = RawScores[3];
                scores["DEX"] = RawScores[4];
                scores["STR"] = RawScores[5];
                return new Dictionary<string, int>();
            }
        }

        public Dictionary<string, int> ArrangeWarlockScores(int[] rawScores)
        {
            if (rawScores.Length > 0)
            {
                Dictionary<string, int> _scores = new Dictionary<string, int>()
                {
                    {"CHA",rawScores[0]},
                    {"CON",rawScores[1]},
                    {"DEX",rawScores[2]},
                    {"WIS",rawScores[3]},
                    {"INT",rawScores[4]},
                    {"STR",rawScores[5]},
                };
                return _scores;
            }
            else
            {
                scores["CHA"] = RawScores[0];
                scores["CON"] = RawScores[1];
                scores["DEX"] = RawScores[2];
                scores["WIS"] = RawScores[3];
                scores["INT"] = RawScores[4];
                scores["STR"] = RawScores[5];
                return new Dictionary<string, int>();
            }
        }

        public Dictionary<string, int> ArrangeWizardScores(int[] rawScores)
        {
            if (rawScores.Length > 0)
            {
                Dictionary<string, int> _scores = new Dictionary<string, int>()
                {
                    {"INT",rawScores[0]},
                    {"CON",rawScores[1]},
                    {"DEX",rawScores[2]},
                    {"WIS",rawScores[3]},
                    {"CHA",rawScores[4]},
                    {"STR",rawScores[5]},
                };
                return _scores;
            }
            else
            {
                scores["INT"] = RawScores[0];
                scores["CON"] = RawScores[1];
                scores["DEX"] = RawScores[2];
                scores["WIS"] = RawScores[3];
                scores["CHA"] = RawScores[4];
                scores["STR"] = RawScores[5];
                return new Dictionary<string, int>();
            }
        }

        public Dictionary<string, int> ArrangeFighterScores(int[] rawScores)
        {
            if (rawScores.Length > 0)
            {
                Dictionary<string, int> _scores = new Dictionary<string, int>()
                {
                    {"STR",rawScores[0]},
                    {"CON",rawScores[1]},
                    {"DEX",rawScores[2]},
                    {"WIS",rawScores[3]},
                    {"CHA",rawScores[4]},
                    {"INT",rawScores[5]},
                };
                return _scores;
            }
            else
            {
                scores["STR"] = RawScores[0];
                scores["CON"] = RawScores[1];
                scores["DEX"] = RawScores[2];
                scores["WIS"] = RawScores[3];
                scores["CHA"] = RawScores[4];
                scores["INT"] = RawScores[5];
                return new Dictionary<string, int>();
            }
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