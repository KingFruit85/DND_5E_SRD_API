using System;
using System.Collections.Generic;

namespace DND_5E_SRD_API.Models
{
    public class AbilityScores
    {
        private int[] RawScores = new Dice().ReturnAbilityScores();
        public Dictionary<string, int> scores { get; set; } = new Dictionary<string, int>()
        {
            {"str",0},
            {"dex",0},
            {"con",0},
            {"int",0},
            {"wis",0},
            {"cha",0},
        };


        public void Arrange(string characterClassName)
        {
            int[] rawScores = new int[] { };
            switch (characterClassName.ToLower().Trim())
            {
                case "bard":
                    ArrangeBardScores(rawScores);
                    break;

                case "barbarian":
                    ArrangeBarbarianScores(rawScores);
                    break;

                case "cleric":
                    ArrangeClericScores(rawScores);
                    break;

                case "fighter":
                    ArrangeFighterScores(rawScores);
                    break;

                case "monk":
                    ArrangeMonkScores(rawScores);
                    break;

                case "paladin":
                    ArrangePaladinScores(rawScores);
                    break;

                case "ranger":
                    ArrangeRangerScores(rawScores);
                    break;

                case "rogue":
                    ArrangeRogueScores(rawScores);
                    break;

                case "sorcerer":
                    ArrangeSorcererScores(rawScores);
                    break;

                case "warlock":
                    ArrangeWarlockScores(rawScores);
                    break;

                case "wizard":
                    ArrangeWizardScores(rawScores);
                    break;

                case "druid":
                    ArrangeDruidScores(rawScores);
                    break;

                default: throw new Exception("class name wasn't caught");
            }

        }

        public Dictionary<string, int> Arrange(string characterClassName, int[] rawScores)
        {
            switch (characterClassName.ToLower().Trim())
            {
                case "bard":return ArrangeBardScores(rawScores);
                case "barbarian":return ArrangeBarbarianScores(rawScores);
                case "cleric":return ArrangeClericScores(rawScores);
                case "fighter":return ArrangeFighterScores(rawScores);
                case "monk":return ArrangeMonkScores(rawScores);
                case "paladin":return ArrangePaladinScores(rawScores);
                case "ranger":return ArrangeRangerScores(rawScores);
                case "rogue":return ArrangeRogueScores(rawScores);
                case "sorcerer":return ArrangeSorcererScores(rawScores);
                case "warlock":return ArrangeWarlockScores(rawScores);
                case "wizard":return ArrangeWizardScores(rawScores);
                case "druid":return ArrangeDruidScores(rawScores);
                default: throw new Exception("class name wasn't caught");
            }
        }

        public Dictionary<string, int> ArrangeBardScores(int[] rawScores)
        {
            if (rawScores.Length > 0)
            {
                Dictionary<string, int> _scores = new Dictionary<string, int>()
                {
                    {"cha",rawScores[0]},
                    {"dex",rawScores[1]},
                    {"con",rawScores[2]},
                    {"wis",rawScores[3]},
                    {"str",rawScores[4]},
                    {"int",rawScores[5]},
                };
                return _scores;
            }
            else
            {
                scores["cha"] = RawScores[0];
                scores["dex"] = RawScores[1];
                scores["con"] = RawScores[2];
                scores["wis"] = RawScores[3];
                scores["str"] = RawScores[4];
                scores["int"] = RawScores[5];
                return new Dictionary<string, int>();
            }
        }

        public Dictionary<string, int> ArrangeBarbarianScores(int[] rawScores)
        {
            if (rawScores.Length > 0)
            {
                Dictionary<string, int> _scores = new Dictionary<string, int>()
                {
                    {"str",rawScores[0]},
                    {"con",rawScores[1]},
                    {"dex",rawScores[2]},
                    {"wis",rawScores[3]},
                    {"cha",rawScores[4]},
                    {"int",rawScores[5]},
                };
                return _scores;
            }
            else
            {
                scores["str"] = RawScores[0];
                scores["con"] = RawScores[1];
                scores["dex"] = RawScores[2];
                scores["wis"] = RawScores[3];
                scores["cha"] = RawScores[4];
                scores["int"] = RawScores[5];
                return new Dictionary<string, int>();
            }
        }

        public Dictionary<string, int> ArrangeMonkScores(int[] rawScores)
        {
            if (rawScores.Length > 0)
            {
                Dictionary<string, int> _scores = new Dictionary<string, int>()
                {
                    {"dex",rawScores[0]},
                    {"wis",rawScores[1]},
                    {"con",rawScores[2]},
                    {"str",rawScores[3]},
                    {"cha",rawScores[4]},
                    {"int",rawScores[5]},
                };
                return _scores;
            }
            else
            {
                scores["dex"] = RawScores[0];
                scores["wis"] = RawScores[1];
                scores["con"] = RawScores[2];
                scores["str"] = RawScores[3];
                scores["cha"] = RawScores[4];
                scores["int"] = RawScores[5];
                return new Dictionary<string, int>();
            }
        }

        public Dictionary<string, int> ArrangeClericScores(int[] rawScores)
        {
            if (rawScores.Length > 0)
            {
                Dictionary<string, int> _scores = new Dictionary<string, int>()
                {
                    {"wis",rawScores[0]},
                    {"str",rawScores[1]},
                    {"con",rawScores[2]},
                    {"dex",rawScores[3]},
                    {"cha",rawScores[4]},
                    {"int",rawScores[5]},
                };
                return _scores;
            }
            else
            {
                scores["wis"] = RawScores[0];
                scores["str"] = RawScores[1];
                scores["con"] = RawScores[2];
                scores["dex"] = RawScores[3];
                scores["cha"] = RawScores[4];
                scores["int"] = RawScores[5];
                return new Dictionary<string, int>();
            }
        }


        public Dictionary<string, int> ArrangeDruidScores(int[] rawScores)
        {
            if (rawScores.Length > 0)
            {
                Dictionary<string, int> _scores = new Dictionary<string, int>()
                {
                    {"wis",rawScores[0]},
                    {"dex",rawScores[1]},
                    {"con",rawScores[2]},
                    {"cha",rawScores[3]},
                    {"int",rawScores[4]},
                    {"str",rawScores[5]},
                };
                return _scores;
            }
            else
            {
                scores["wis"] = RawScores[0];
                scores["dex"] = RawScores[1];
                scores["con"] = RawScores[2];
                scores["cha"] = RawScores[3];
                scores["int"] = RawScores[4];
                scores["str"] = RawScores[5];
                return new Dictionary<string, int>();

            }
        }


        public Dictionary<string, int> ArrangePaladinScores(int[] rawScores)
        {
            if (rawScores.Length > 0)
            {
                Dictionary<string, int> _scores = new Dictionary<string, int>()
                {
                    {"wis",rawScores[0]},
                    {"dex",rawScores[1]},
                    {"con",rawScores[2]},
                    {"cha",rawScores[3]},
                    {"int",rawScores[4]},
                    {"str",rawScores[5]},
                };
                return _scores;
            }
            else
            {
                scores["wis"] = RawScores[0];
                scores["dex"] = RawScores[1];
                scores["con"] = RawScores[2];
                scores["cha"] = RawScores[3];
                scores["int"] = RawScores[4];
                scores["str"] = RawScores[5];
                return new Dictionary<string, int>();
            }
        }

        public Dictionary<string, int> ArrangeRangerScores(int[] rawScores)
        {
            if (rawScores.Length > 0)
            {
                Dictionary<string, int> _scores = new Dictionary<string, int>()
                {
                    {"dex",rawScores[0]},
                    {"con",rawScores[1]},
                    {"wis",rawScores[2]},
                    {"str",rawScores[3]},
                    {"cha",rawScores[4]},
                    {"int",rawScores[5]},
                };
                return _scores;
            }
            else
            {
                scores["dex"] = RawScores[0];
                scores["con"] = RawScores[1];
                scores["wis"] = RawScores[2];
                scores["str"] = RawScores[3];
                scores["cha"] = RawScores[4];
                scores["int"] = RawScores[5];
                return new Dictionary<string, int>();
            }
        }

        public Dictionary<string, int> ArrangeRogueScores(int[] rawScores)
        {
            if (rawScores.Length > 0)
            {
                Dictionary<string, int> _scores = new Dictionary<string, int>()
                {
                    {"dex",rawScores[0]},
                    {"con",rawScores[1]},
                    {"wis",rawScores[2]},
                    {"cha",rawScores[3]},
                    {"int",rawScores[4]},
                    {"str",rawScores[5]},
                };
                return _scores;
            }
            else
            {
                scores["dex"] = RawScores[0];
                scores["con"] = RawScores[1];
                scores["wis"] = RawScores[2];
                scores["cha"] = RawScores[3];
                scores["int"] = RawScores[4];
                scores["str"] = RawScores[5];
                return new Dictionary<string, int>();
            }
        }

        public Dictionary<string, int> ArrangeSorcererScores(int[] rawScores)
        {
            if (rawScores.Length > 0)
            {
                Dictionary<string, int> _scores = new Dictionary<string, int>()
                {
                    {"cha",rawScores[0]},
                    {"con",rawScores[1]},
                    {"int",rawScores[2]},
                    {"wis",rawScores[3]},
                    {"dex",rawScores[4]},
                    {"str",rawScores[5]},
                };
                return _scores;
            }
            else
            {
                scores["cha"] = RawScores[0];
                scores["con"] = RawScores[1];
                scores["int"] = RawScores[2];
                scores["wis"] = RawScores[3];
                scores["dex"] = RawScores[4];
                scores["str"] = RawScores[5];
                return new Dictionary<string, int>();
            }
        }

        public Dictionary<string, int> ArrangeWarlockScores(int[] rawScores)
        {
            if (rawScores.Length > 0)
            {
                Dictionary<string, int> _scores = new Dictionary<string, int>()
                {
                    {"cha",rawScores[0]},
                    {"con",rawScores[1]},
                    {"dex",rawScores[2]},
                    {"wis",rawScores[3]},
                    {"int",rawScores[4]},
                    {"str",rawScores[5]},
                };
                return _scores;
            }
            else
            {
                scores["cha"] = RawScores[0];
                scores["con"] = RawScores[1];
                scores["dex"] = RawScores[2];
                scores["wis"] = RawScores[3];
                scores["int"] = RawScores[4];
                scores["str"] = RawScores[5];
                return new Dictionary<string, int>();
            }
        }

        public Dictionary<string, int> ArrangeWizardScores(int[] rawScores)
        {
            if (rawScores.Length > 0)
            {
                Dictionary<string, int> _scores = new Dictionary<string, int>()
                {
                    {"int",rawScores[0]},
                    {"con",rawScores[1]},
                    {"dex",rawScores[2]},
                    {"wis",rawScores[3]},
                    {"cha",rawScores[4]},
                    {"str",rawScores[5]},
                };
                return _scores;
            }
            else
            {
                scores["int"] = RawScores[0];
                scores["con"] = RawScores[1];
                scores["dex"] = RawScores[2];
                scores["wis"] = RawScores[3];
                scores["cha"] = RawScores[4];
                scores["str"] = RawScores[5];
                return new Dictionary<string, int>();
            }
        }

        public Dictionary<string, int> ArrangeFighterScores(int[] rawScores)
        {
            if (rawScores.Length > 0)
            {
                Dictionary<string, int> _scores = new Dictionary<string, int>()
                {
                    {"str",rawScores[0]},
                    {"con",rawScores[1]},
                    {"dex",rawScores[2]},
                    {"wis",rawScores[3]},
                    {"cha",rawScores[4]},
                    {"int",rawScores[5]},
                };
                return _scores;
            }
            else
            {
                scores["str"] = RawScores[0];
                scores["con"] = RawScores[1];
                scores["dex"] = RawScores[2];
                scores["wis"] = RawScores[3];
                scores["cha"] = RawScores[4];
                scores["int"] = RawScores[5];
                return new Dictionary<string, int>();
            }
        }

        public int[] GetRawScores()
        {
            return RawScores;
        }

        public void SetStrengthScore(int score)
        {
            scores["str"] = score;
        }

        public int GetStrengthScore()
        {
            return scores["str"];
        }

        public void SetDexterityScore(int score)
        {
            scores["dex"] = score;
        }

        public int GetDexterityScore()
        {
            return scores["dex"];
        }

        public void SetConstitutionScore(int score)
        {
            scores["con"] = score;
        }

        public int GetConstitutionScore()
        {
            return scores["con"];
        }

        public void SetIntelligenceScore(int score)
        {
            scores["int"] = score;
        }

        public int GetIntelligenceScore()
        {
            return scores["int"];
        }

        public void SetWisdomScore(int score)
        {
            scores["wis"] = score;
        }

        public int GetWisdomScore()
        {
            return scores["wis"];
        }

        public void SetCharismaScore(int score)
        {
            scores["cha"] = score;
        }

        public int GetCharismaScore()
        {
            return scores["cha"];
        }

        public double getAbilityScoreModifier(int score)
        {
            return Math.Floor(((double)score - 10) / 2);
        }

        public double getAbilityScoreModifier(string score)
        {
            switch (score)
            {
                default: throw new Exception($"A valid ability score string was not provided, provided = {score}");
                case "str": return getAbilityScoreModifier(scores[score]);
                case "dex": return getAbilityScoreModifier(scores[score]);
                case "con": return getAbilityScoreModifier(scores[score]);
                case "int": return getAbilityScoreModifier(scores[score]);
                case "wis": return getAbilityScoreModifier(scores[score]);
                case "cha": return getAbilityScoreModifier(scores[score]);
            }
        }

        public void SetScore(string stat, int score)
        {
            switch (stat)
            {
                case "str":
                    scores["str"] += score;
                    break;
                case "dex":
                    scores["dex"] += score;
                    break;
                case "con":
                    scores["con"] += score;
                    break;
                case "wis":
                    scores["wis"] += score;
                    break;
                case "int":
                    scores["int"] += score;
                    break;
                case "cha":
                    scores["cha"] += score;
                    break;

                default: throw new Exception("Unable to increment ability score");
            }
        }
    }
}