using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND_5E_SRD_API.Models.BackStory
{
    public static class BackStory
    {
        static List<string> descriptors = new List<string>()
        {
            "able",
            "abnormal",
            "absent-minded",
            "above average",
            "adventurous",
            "affectionate",
            "agile",
            "agreeable",
            "alert",
            "amazing",
            "ambitious",
            "amiable",
            "amusing",
            "analytical",
            "angelic",
            "apathetic",
            "apprehensive",
            "ardent",
            "artificial",
            "artistic",
            "assertive",
            "attentive",
            "average",
            "awesome",
            "awful",
            "balanced",
            "beautiful",
            "below average",
            "beneficent",
            "blue",
            "blunt",
            "boisterous",
            "brave",
            "bright",
            "brilliant",
            "buff",
            "callous",
            "candid",
            "cantankerous",
            "capable",
            "careful",
            "careless",
            "caustic",
            "cautious",
            "charming",
            "childish",
            "childlike",
            "cheerful",
            "chic",
            "churlish",
            "circumspect",
            "civil",
            "clean",
            "clever",
            "clumsy",
            "coherent",
            "cold",
            "competent",
            "composed",
            "conceited",
            "condescending",
            "confident",
            "confused",
            "conscientious",
            "considerate",
            "content",
            "cool",
            "cool-headed",
            "cooperative",
            "cordial",
            "courageous",
            "cowardly",
            "crabby",
            "crafty",
            "cranky",
            "crass",
            "critical",
            "cruel",
            "curious",
            "cynical",
            "dainty",
            "decisive",
            "deep",
            "deferential",
            "deft",
            "delicate",
            "demonic",
            "dependent",
            "delightful",
            "demure",
            "depressed",
            "devoted",
            "dextrous",
            "diligent",
            "direct",
            "dirty",
            "disagreeable",
            "discerning",
            "discreet",
            "disruptive",
            "distant",
            "distraught",
            "distrustful",
            "dowdy",
            "dramatic",
            "dreary",
            "drowsy",
            "drugged",
            "drunk",
            "dull",
            "dutiful",
            "eager",
            "earnest",
            "easy-going",
            "efficient",
            "egotistical",
            "elfin",
            "emotional",
            "energetic",
            "enterprising",
            "enthusiastic",
            "evasive",
            "even-tempered",
            "exacting",
            "excellent",
            "excitable",
            "experienced",
            "fabulous",
            "fastidious",
            "ferocious",
            "fervent",
            "fiery",
            "flabby",
            "flaky",
            "flashy",
            "frank",
            "friendly",
            "funny",
            "fussy",
            "generous",
            "gentle",
            "gloomy",
            "glutinous",
            "good",
            "grave",
            "great",
            "groggy",
            "grouchy",
            "guarded",
            "hateful",
            "hearty",
            "helpful",
            "hesitant",
            "hot-headed",
            "hypercritical",
            "hysterical",
            "idiotic",
            "idle",
            "illogical",
            "imaginative",
            "immature",
            "immodest",
            "impatient",
            "imperturbable",
            "impetuous",
            "impractical",
            "impressionable",
            "impressive",
            "impulsive",
            "inactive",
            "incisive",
            "incompetent",
            "inconsiderate",
            "inconsistent",
            "independent",
            "indiscreet",
            "indolent",
            "indefatigable",
            "industrious",
            "inexperienced",
            "insensitive",
            "inspiring",
            "intelligent",
            "interesting",
            "intolerant",
            "inventive",
            "irascible",
            "irritable",
            "irritating",
            "jocular",
            "jovial",
            "joyous",
            "judgmental",
            "keen",
            "kind",
            "lame",
            "lazy",
            "lean",
            "leery",
            "lethargic",
            "level-headed",
            "listless",
            "lithe",
            "lively",
            "local",
            "logical",
            "long-winded",
            "lovable",
            "love-lorn",
            "lovely",
            "maternal",
            "mature",
            "mean",
            "meddlesome",
            "mercurial",
            "methodical",
            "meticulous",
            "mild",
            "miserable",
            "modest",
            "moronic",
            "morose",
            "motivated",
            "musical",
            "naive",
            "nasty",
            "natural",
            "naughty",
            "negative",
            "nervous",
            "noisy",
            "normal",
            "nosy",
            "numb",
            "obliging",
            "obnoxious",
            "old-fashioned",
            "one-sided",
            "orderly",
            "ostentatious",
            "outgoing",
            "outspoken",
            "passionate",
            "passive",
            "paternal",
            "paternalistic",
            "patient",
            "peaceful",
            "peevish",
            "pensive",
            "persevering",
            "persnickety",
            "petulant",
            "picky",
            "plain",
            "plain-speaking",
            "playful",
            "pleasant",
            "plucky",
            "polite",
            "popular",
            "positive",
            "powerful",
            "practical",
            "prejudiced",
            "pretty",
            "proficient",
            "proud",
            "provocative",
            "prudent",
            "punctual",
            "quarrelsome",
            "querulous",
            "quick",
            "quick-tempered",
            "quiet",
            "realistic",
            "reassuring",
            "reclusive",
            "reliable",
            "reluctant",
            "resentful",
            "reserved",
            "resigned",
            "resourceful",
            "respected",
            "respectful",
            "responsible",
            "restless",
            "revered",
            "ridiculous",
            "sad",
            "sassy",
            "saucy",
            "sedate",
            "self-assured",
            "selfish",
            "sensible",
            "sensitive",
            "sentimental",
            "serene",
            "serious",
            "sharp",
            "short-tempered",
            "shrewd",
            "shy",
            "silly",
            "sincere",
            "sleepy",
            "slight",
            "sloppy",
            "slothful",
            "slovenly",
            "slow",
            "smart",
            "snazzy",
            "sneering",
            "snobby",
            "somber",
            "sober",
            "sophisticated",
            "soulful",
            "soulless",
            "sour",
            "spirited",
            "spiteful",
            "stable",
            "staid",
            "steady",
            "stern",
            "stoic",
            "striking",
            "strong",
            "stupid",
            "sturdy",
            "subtle",
            "sullen",
            "sulky",
            "supercilious",
            "superficial",
            "surly",
            "suspicious",
            "sweet",
            "tactful",
            "tactless",
            "talented",
            "testy",
            "thinking",
            "thoughtful",
            "thoughtless",
            "timid",
            "tired",
            "tolerant",
            "touchy",
            "tranquil",
            "ugly",
            "unaffected",
            "unbalanced",
            "uncertain",
            "uncooperative",
            "undependable",
            "unemotional",
            "unfriendly",
            "unguarded",
            "unhelpful",
            "unimaginative",
            "unmotivated",
            "unpleasant",
            "unpopular",
            "unreliable",
            "unsophisticated",
            "unstable",
            "unsure",
            "unthinking",
            "unwilling",
            "venal",
            "versatile",
            "vigilant",
            "warm",
            "warmhearted",
            "wary",
            "watchful",
            "weak",
            "well-behaved",
            "well-developed",
            "well-intentioned",
            "well-respected",
            "well-rounded",
            "willing",
            "wonderful",
            "volcanic",
            "vulnerable",
            "zealous"
        };

        static List<string> bodyParts = new List<string>()
        {
            "ankle",
            "arm",
            "back",
            "belly",
            "bottom",
            "breast",
            "buttocks",
            "calf",
            "cheek",
            "chin",
            "ear",
            "elbow",
            "eye",
            "eyebrow",
            "eyelash",
            "finger",
            "fist",
            "foot",
            "forearm",
            "forehead",
            "hair",
            "hand",
            "head",
            "hip",
            "knee",
            "leg",
            "lip",
            "lower leg",
            "mouth",
            "neck",
            "nose",
            "nostril",
            "shoulder",
            "thigh",
            "thumb",
            "toe",
            "tongue",
            "tooth",
            "upper arm",
            "waist",
            "wrist"
        };


        static List<string> professions = new List<string>()
        {
              "Actor",
              "Lawyer",
              "Alchemist",
              "Animal Handler",
              "Apothecary",
              "Architect",
              "Archer",
              "Archivist",
              "Aristocrat",
              "Armorer",
              "Artisan",
              "Artist",
              "Astrologer",
              "Baker",
              "Banker",
              "Barbarian",
              "Barber",
              "Bard",
              "Barkeep",
              "Barmaid",
              "Beekeeper",
              "Beer",
              "Seller",
              "Beggar",
              "Blacksmith",
              "Boatman",
              "Bookbinder",
              "Bookseller",
              "Brewer",
              "Bricklayer",
              "Brick Maker",
              "Brigand",
              "Brothel Keeper",
              "Buckle Maker",
              "Builder",
              "Butcher",
              "Caravan Leader",
              "Carpenter",
              "Cartographer",
              "Chandler",
              "Charioteer",
              "Chatelaine",
              "Chef",
              "Chieftain",
              "Chirurgeon",
              "Clergyman",
              "Clerk",
              "Clock Maker",
              "Clothworker",
              "Cobbler",
              "Commander",
              "Concubine",
              "Cook",
              "Cooper",
              "Copyist",
              "Costermonger",
              "Counselor",
              "Courtesan",
              "Courtier",
              "Cowherd",
              "Crossbowman",
              "Cutler",
              "Daimyo",
              "Dairymaid",
              "Dancer",
              "Diplomat",
              "Distiller",
              "Diver",
              "Diviner",
              "Doctor",
              "Domestic Servant",
              "Eunuch",
              "Explorer",
              "Farmer",
              "Fighter",
              "Fisherman",
              "Fishmonger",
              "Footman",
              "Furrier",
              "Galley Slave",
              "Gardener",
              "Geisha",
              "General",
              "Gladiator",
              "Glovemaker",
              "Goldsmith",
              "Grocer",
              "Groom",
              "Guardsman",
              "Guildmaster",
              "Harness maker",
              "Hatmaker",
              "Hay merchant",
              "Healer",
              "Herald",
              "Herbalist",
              "Herder",
              "Hermit",
              "Highwayman",
              "Historian",
              "Housemaid",
              "Hunter",
              "Illuminator",
              "Infantryman",
              "Innkeeper",
              "Interpreter",
              "Inventor",
              "Jailer",
              "Jester",
              "Jeweler",
              "Jongleur",
              "Judge",
              "Kitchen drudge",
              "Knight",
              "Laborer",
              "Lady	Lady in Waiting",
              "Leatherworker",
              "Librarian",
              "Linguist",
              "Locksmith",
              "Longbowman",
              "Longshoreman",
              "Maidservant",
              "Man at Arms",
              "Mason",
              "Masseur",
              "Mayor",
              "Mercer",
              "Merchant",
              "Messenger",
              "Midwife",
              "Miller",
              "Miner",
              "Minister",
              "Minstrel",
              "Monk",
              "Mortician",
              "Mourner",
              "Musician",
              "Necromancer",
              "Noble",
              "Nun",
              "Nurse",
              "Old-clothes seller",
              "Page",
              "Painter",
              "Pariah",
              "Pastry cook",
              "Peasant",
              "Perfumer",
              "Philosopher",
              "Physician",
              "Pigkeeper",
              "Pilgrim",
              "Pirate",
              "Plasterer",
              "Potter",
              "Priestess",
              "Princess",
              "Privateer",
              "Professor",
              "Prostitute",
              "Pursemaker",
              "Queen",
              "Ranger",
              "Ratcatcher",
              "Reeve",
              "Ronin",
              "Roofer",
              "Ropemaker",
              "Royal",
              "Adviser",
              "Rugmaker",
              "Ruler",
              "Saddler",
              "Sailor",
              "Samurai",
              "Scabbard maker",
              "Sculptor",
              "Scavenger",
              "Scholar",
              "Scrivener",
              "Seamstress",
              "Servant",
              "Shaman",
              "Shepherd",
              "Ship's captain",
              "Shoemaker",
              "Silversmith",
              "Slave",
              "Slaver",
              "Smith",
              "Soldier",
              "Sorcerer",
              "Sorceress",
              "Spice Merchant",
              "Squire",
              "Stablehand",
              "Stevedore",
              "Stonemason",
              "Storyteller",
              "Steward",
              "Street kid",
              "Street seller",
              "Street sweeper",
              "Student",
              "Surgeon",
              "Surveyor",
              "Swordsman",
              "Sycophant",
              "Tailor",
              "Tanner",
              "Tavernkeeper",
              "Tax collector",
              "Teacher",
              "Teamster",
              "Thatcher",
              "Thief",
              "Tinker",
              "Torturer",
              "Town crier",
              "Toymaker",
              "Trapper",
              "Vendor",
              "Vermin catcher",
              "Veterinarian",
              "Village chief",
              "Vintner",
              "Viking",
              "Warlock",
              "Warrior",
              "Water carrier",
              "Weaver",
              "Wetnurse",
              "Wine seller",
              "Witch",
              "Wizard",
              "Woodcarver",
              "Woodcutter",
              "Wood seller",
              "Wrestler",
              "Writer"
        };

        static List<string> animals = new List<string>()
        {
            "Bison",
            "Bison",
            "Eagle",
            "Pony",
            "Ape",
            "Lobster",
            "Monkey",
            "Cow",
            "Deer",
            "Horse",
            "Dog",
            "Goat",
            "Pig",
            "Sheep",
            "Cat",
            "Chicken",
            "Duck",
            "Dove",
            "Rabbit",
            "Mice",
            "Rat",
            "Deer",
            "Bat"
        };

        static List<string> mentalState = new List<string>()
        {
            "Mad",
            "Sane",
            "Scared",
            "Angry",
            "Frightend",
            "Upset",
            "Calm",
            "Possessed",
            "Ghost",
            "Crawling",
            "Slow moving",
            "Rabid",
            "Insane",
            "Hungry",
            "Bored",
            "Depressed"
        };

        static List<string> food = new List<string>()
        {
            "black beans",
            "pinto beans",
            "kidney beans",
            "sun-dried tomatoes",
            "tuna",
            "salmon",
            "minced clams",
            "sugar",
            "milk",
            "chicken",
            "beef",
            "turkey",
            "pork",
            "bacon",
            "carrots",
            "melons",
            "apple sauce",
            "avocado",
            "duck hearts",
            "apples"
        };

        static List<string> state = new List<string>()
        {
            "old",
            "fresh",
            "mouldy",
            "rotten",
            "dried",
            "vegan",
            "ripe",
            "unripened",
            "perished",
            "soiled",
            "raw",
            "over cooked",
            "under cooked",
            "tart",
            "tangy",
            "sour",
            "sweet",
            "thrice cooked",
            "fermented",
            "par-boiled",
            "distiled",
            "bloody",
            "reduced",
            "cream of"
        };

        static List<string> buildings = new List<string>()
        {
            "Abbatoir",
            "Barn",
            "Chicken coop",
            "Cow-shed",
            "Farmhouse",
            "Granary, Hórreo",
            "Greenhouse",
            "Hayloft",
            "Pigpen",
            "Root cellar",
            "Shed",
            "Silo",
            "Slaughterhouse",
            "Stable",
            "Storm cellar",
            "Well house",
            "Crib",
            "Windmill",
            "Bakery",
            "Beauty salon",
            "Bookshop",
            "Clinic",
            "Community hall",
            "Department store",
            "Eatery",
            "Inn",
            "Floristry",
            "Folly",
            "Food court",
            "Gym",
            "Hospice",
            "Hospital",
            "Mini market",
            "Office building",
            "Pizzeria",
            "Plant nursery",
            "Pub",
            "Bathhouse",
            "Stall",
            "Sport club",
            "Bar",
            "Wet market",
            "Workshop"
        };

        static List<string> feeling = new List<string>()
        {
            "love",
            "hate",
            "dispise",
            "lust after",
            "fear",
        };

        static List<string> things = new List<string>()
        {
            "flowers",
            "puddles",
            "stale bread",
            "chalk",
            "soap",
            "Rocks",
            "money",
            "Milk",
            "rusty nails"
        };

        static List<string> races = new List<string>()
        {
            "human","dwarf","elf","gnome","halfling","dragonborn","half-elf","half-orc","tiefling"
        };

        public static string GetLifeDetails()
        {
            Random r = new Random();
            switch (r.Next(1, 24))
            {
                case 1: return $"You were abandoned at birth by your parents and fended for youself on the streets";
                case 2: return $"You were raised in a now disgraced noble family and are trying to reclaim your previous status";
                case 3: return $"You were a divine birth conceived between lesser Gods and Demons, abandoned at birth you have been seeking out your parents";
                case 4: return $"You and your siblings learnt to speak backwards perfectly as children to pass each other secret messages";
                case 5: return $"You were raised in a cult, believing you alone have the power to stop the prophecy coming true...";
                case 6: return $"After a freak wizard accident you permanently lost all hair over your body";
                case 7: return $"You were hit in the head recently and lost all your memories, you now believe you are an extremely elderly member of the opposite sex";
                case 8: return $"You grew up poor and shunned by others. In your adolescence you joined a street gang, after a failed robbery you had a bounty placed on your head and had to flee";
                case 9: return $"Your life has been spent cheating death, trouble seems to find you around every corner";
                case 10: return $"You grew up in magical floating city despite not believing in magic";
                case 11: return $"You grew up in a haunted castle and due to your experiences, there you are now downright racist to living skeletons";
                case 12: return $"You grew up in a boarding school for middle class wizards who you did not care for at all";
                case 13: return $"Your life has been a cruel collection of practical jokes made at your expense. You finally snapped one day and do not speak about what happened to anyone";
                case 14: return $"Your best friend growing up convinced you that the world had a solid gold core. You are always hatching schemes to claim the gold core for your own";
                case 15: return $"You grew up in a farming village where you tended {Tools.GetRandomListElement(animals)}s and {Tools.GetRandomListElement(animals)}s";
                case 16: return $"You didn't see the light of day until you were {r.Next(5, 15)} years old";
                case 17: return $"You were raised in a perfectly stable family that was wiped out by  {Tools.GetRandomListElement(mentalState)} {Tools.GetRandomListElement(animals)}s";
                case 18: return $"You were dropped on your head as a child, ever since then you believe you can speak to {Tools.GetRandomListElement(animals)}s. You can't.";
                case 19: return $"You were abandoned at birth and grew up in a scary forest cared for by {Tools.GetRandomListElement(animals)}s";
                case 20: return $"You were raised in a {Tools.GetRandomListElement(buildings)} where you became addicted to {Tools.GetRandomListElement(state)} {Tools.GetRandomListElement(food)}";
                case 21: return $"You grew up in a {Tools.GetRandomListElement(buildings)}, and your only friend was a {Tools.GetRandomListElement(mentalState)} {Tools.GetRandomListElement(animals)}";
                case 22: return $"You were sold into slavery at a young age. You grew up in the slave pits, fighting for the amusement of others. During your final fight you blacked out after receiving a mortal wound and woke up fully healed in a {Tools.GetRandomListElement(buildings)}";
                case 23: return $"You took a vow of non-silence when you were {r.Next(1, 15)} years old and are constantly making some sort of noise";
                default: return "";
            }
        }

        public static string GetLikesDetails()
        {
            Random r = new Random();
            switch (r.Next(1, 24))
            {
                case 1: return $"You love the smell of {Tools.GetRandomListElement(things)})";
                case 2: return $"You are addicted to {Tools.GetRandomListElement(animals)} milk";
                case 3: return $"You collect various preserves";
                case 4: return $"You love {Tools.GetRandomListElement(races)} chocolate";
                case 5: return $"You love {Tools.GetRandomListElement(races)} honey";
                case 6: return $"You are very proud of your body and like to wear as little clothes as possible when appropriate";
                case 7: return $"You love a {Tools.GetRandomListElement(state)} {Tools.GetRandomListElement(food)}";
                case 8: return $"You do not eat meat of any kind";
                case 9: return $"You love to collect {Tools.GetRandomListElement(animals)} figurines";
                case 10: return $" You {Tools.GetRandomListElement(feeling)} the elderly";
                case 11: return $"You love skinny dipping";
                case 12: return $"You love music and often hum popular songs out loud";
                case 13: return $"You love trying new foods";
                case 14: return $"You love to suck on smooth stones";
                case 15: return $"You like to chew hay";
                case 16: return $"You enjoy the elegance of {Tools.GetRandomListElement(animals)}s";
                case 17: return $"You like to learn about other cultures";
                case 18: return $"You love cracking your knuckles";
                case 19: return $"You are very impressed with your ability to cartwheel and like to show off in public places";
                case 20: return $"You love to paint";
                case 21: return $"You love to express your feelings though the medium of dance";
                case 22: return $"You love to read trashy romance novels";
                case 23: return $"You like to compliment people on their fashion sense";
                default: return "";
            }
        }

        public static string GetDislikesDetails()
        {
            Random r = new Random();
            switch (r.Next(1, 21))
            {
                case 1: return $"You think the elderly are useless";
                case 2: return $"You cannot stand the darkness";
                case 3: return $"You cannot stand the light of day";
                case 4: return $"You hate small talk";
                case 5: return $"You {Tools.GetRandomListElement(feeling)} {Tools.GetRandomListElement(animals)}s";
                case 6: return $"You dislike getting up in the morning";
                case 7: return $"You avoid eye contact with people smaller than you at all costs";
                case 8: return $"You hate anyone taller than you";
                case 9: return $"You are terrified by any building with more than one floor";
                case 10: return $"You are mortal enemies with a badger named Gary";
                case 11: return $"You can't stand children";
                case 12: return $"You can't be bothered to remember people’s names";
                case 13: return $"You if you see someone yawning you will attempt to cover their mouths for them";
                case 14: return $"You can't stand the homeless";
                case 15: return $"You hate any sweet foods";
                case 16: return $"You think {Tools.GetRandomListElement(things)} are pointless";
                case 17: return $"You can't stand the sight of {Tools.GetRandomListElement(buildings)}s";
                case 18: return $"You hate dwelling on the past";
                case 19: return $"You hate being woken up";
                case 20: return $"You fear heights";
                default: return "";
            }
        }

        public static string GetQuirkDetails()
        {
            Random r = new Random();
            switch (r.Next(1, 40))
            {
                case 1: return $"You never back down from a fight, even if it's unwinnable.";
                case 2: return $"You constantly, incorrectly correct other people’s grammar.";
                case 3: return $"You live as if you are the main hero in a bard’s tale and cannot lose.";
                case 4: return $"You have a nervous tick that causes you to flap your arms like a bird when you are embarrassed.";
                case 5: return $"You are constantly distracted by your own mortality.";
                case 6: return $"If you see a horse, you HAVE to pull its tail.";
                case 7: return $"You eat with your mouth open.";
                case 8: return $"You have awful personal hygiene.";
                case 9: return $"You refer to other races as lesser beings.";
                case 10: return $"You believe you were a king in your past life (you were not).";
                case 11: return $"You snore very loudly.";
                case 12: return $"You don't like to eat in front of other people.";
                case 13: return $"As an adult you once lost a child’s eating competition.";
                case 14: return $"You have deep-rooted father issues.";
                case 15: return $"You dream in black and white.";
                case 16: return $"You are always late for social gatherings.";
                case 17: return $"You breathe loudly though your mouth.";
                case 18: return $"You have heterochromia.";
                case 19: return $"You always feel like someone is watching you.";
                case 20: return $"You need alcohol to get though the day.";
                case 21: return $"You have a very pronounced underbite.";
                case 22: return $"You have a very pronounced overbite.";
                case 23: return $"You think moustaches are ridiculously cool but have never been able to grow one yourself.";
                case 24: return $"You didn't choose the Skux life, the Skux life chose you.";
                case 25: return $"You are convinced the {Tools.GetRandomListElement(races)}s are up to something.";
                case 26: return $"You are slightly cross-eyed.";
                case 27: return $"You are slightly boss-eyed.";
                case 28: return $"You blindly follow orders from anyone taller than you.";
                case 29: return $"You have never seen a rainbow and are convinced people are making them up.";
                case 30: return $"You get very nervous opening doors.";
                case 31: return $"You break out in a cold sweat whenever you hear children laughing.";
                case 32: return $"Whenever you see your reflection you stop and become very confused for a moment.";
                case 33: return $"You were chased out of your hometown for stealing {Tools.GetRandomListElement(things)}";
                case 34: return $"You have never been in love.";
                case 35: return $"Your gums bleed excessively.";
                case 36: return $"You quietly cry before you go to sleep.";
                case 37: return $"you are absolutely astonished by jugglers.";
                case 38: return $"you find it impossible to speak to members of the opposite sex.";
                case 39: return $"you tend to end every conversation passive-aggressively.";
                default: return "";
            }
        }

        public static string GetPhysicalDescription(Character c)
        {
            StringBuilder sb = new StringBuilder("");
            sb.Append($"your physique is {GetStrengthDescription(c.AbilityScores.scores["str"])}, ");
            sb.Append($"your movement is {GetDexterityDescription(c.AbilityScores.scores["dex"])}, ");
            sb.Append($"your constitution is that of a {GetConstitutionDescription(c.AbilityScores.scores["con"])}, ");


            sb.Append($"you are known for your {Tools.GetRandomListElement(descriptors)} {Tools.GetRandomListElement(bodyParts)}");


            return sb.ToString();
        }

        static List<string> weakStrengthDescriptors = new List<string>  {"weak", "feeble", "slight", "fragile", "frail", "wasted", "spindly"};
        static List<string> averageStrengthDescriptors = new List<string>  {"average", "mediocre", "ordinary", "regular", "middling", "unexceptional"};
        static List<string> strongStrengthDescriptors = new List<string>  {"strong", "able", "athletic", "forceful", "solid", "vigorous", "mighty"};
        static List<string> apexStrengthDescriptors = new List<string>  { "jacked to the tits", "absurd", "unbelievable", "unimaginable", "godlike", "preposterous", "mindblowing"};

        public static string GetStrengthDescription(int str)
        {

            if (str <= 10)             return Tools.GetRandomListElement(weakStrengthDescriptors);
            if (str >= 10 && str < 16) return Tools.GetRandomListElement(averageStrengthDescriptors);
            if (str >= 16 && str < 19) return Tools.GetRandomListElement(strongStrengthDescriptors);
            if (str >= 19)             return Tools.GetRandomListElement(apexStrengthDescriptors);

            return "-_-";
        }

        static List<string> weakDexterityDescriptors = new List<string> { "lethargic", "sluggish", "stagnant", "idle", "dawdling", "plodding", "drowsy" };
        static List<string> averageDexterityDescriptors = new List<string> { "regular", "plain", "casual", "regular", "so-so", "common" };
        static List<string> strongDexterityDescriptors = new List<string> { "active", "energetic", "powerful", "fast", "alert", "busy", "lively" };
        static List<string> apexDexterityDescriptors = new List<string> { "like quicksilver", "rapid", "like a  blur", "breakneck", "hard to keep up with" };

        public static string GetDexterityDescription(int dex)
        {

            if (dex <= 10) return Tools.GetRandomListElement(weakDexterityDescriptors);
            if (dex >= 10 && dex < 16) return Tools.GetRandomListElement(averageDexterityDescriptors);
            if (dex >= 16 && dex < 19) return Tools.GetRandomListElement(strongDexterityDescriptors);
            if (dex >= 19) return Tools.GetRandomListElement(apexDexterityDescriptors);

            return "-_-";
        }

        static List<string> weakConstitutionDescriptors = new List<string> { "mouse", "fly", "damp rag" };
        static List<string> averageConstitutionDescriptors = new List<string> { "regular person" };
        static List<string> strongConstitutionDescriptors = new List<string> { "ox", "bull", "silverback gorrila" };
        static List<string> apexConstitutionDescriptors = new List<string> { "demi god", "pretty hench bear" };

        public static string GetConstitutionDescription(int con)
        {

            if (con <= 10) return Tools.GetRandomListElement(weakConstitutionDescriptors);
            if (con >= 10 && con < 16) return Tools.GetRandomListElement(averageConstitutionDescriptors);
            if (con >= 16 && con < 19) return Tools.GetRandomListElement(strongConstitutionDescriptors);
            if (con >= 19) return Tools.GetRandomListElement(apexConstitutionDescriptors);

            return "-_-";
        }

        public struct parent
        {
            public string firstName;
            public string occupation;
            public parent(string _firstName, string _occupation)
            {
                firstName = _firstName;
                occupation = _occupation;
            }
        }

        public static string GetParents(Character c)
        {
            List<parent> parents = new List<parent>();
            string parentDetails = string.Empty;

            switch (Tools.GetRandomNumberInRange(0, 5))
            {
                case 0:
                    parentDetails = "You grew up never knowing either of your parents";
                    break;
                case 1:
                    parents.Add(new parent(c.GetRandomFirstName("male", c.RaceDetails.Name), Tools.GetRandomListElement(professions)));
                    parentDetails = $"You were raised by your father {parents[0].firstName} {c.LastName} who is a {parents[0].occupation}";
                    break;
                case 2:
                    parents.Add(new parent(c.GetRandomFirstName("female", c.RaceDetails.Name), Tools.GetRandomListElement(professions)));
                    parentDetails = $"You were raised by your mother {parents[0].firstName} {c.LastName} who is a {parents[0].occupation}";
                    break;
                case 3:
                    parents.Add(new parent(c.GetRandomFirstName("male", c.RaceDetails.Name), Tools.GetRandomListElement(professions)));
                    parents.Add(new parent(c.GetRandomFirstName("female", c.RaceDetails.Name), Tools.GetRandomListElement(professions)));
                    parentDetails = $"You were raised by your father {parents[0].firstName} {c.LastName} who is a {parents[0].occupation}";
                    parentDetails += $" and your mother {parents[1].firstName} {c.LastName} who is a {parents[1].occupation}";
                    break;
                case 4:
                    parents.Add(new parent(c.GetRandomFirstName("female", c.RaceDetails.Name), Tools.GetRandomListElement(professions)));
                    parents.Add(new parent(c.GetRandomFirstName("female", c.RaceDetails.Name), Tools.GetRandomListElement(professions)));
                    parentDetails = $"You were raised by your mothers {parents[0].firstName} {c.LastName} who is a {parents[0].occupation}";
                    parentDetails += $" and {parents[1].firstName} {c.LastName} who is a {parents[1].occupation}";
                    break;
                case 5:
                    parents.Add(new parent(c.GetRandomFirstName("male", c.RaceDetails.Name), Tools.GetRandomListElement(professions)));
                    parents.Add(new parent(c.GetRandomFirstName("male", c.RaceDetails.Name), Tools.GetRandomListElement(professions)));
                    parentDetails = $"You were raised by your fathers {parents[0].firstName} {c.LastName} who is a {parents[0].occupation}";
                    parentDetails += $" and {parents[1].firstName} {c.LastName} who is a {parents[1].occupation}";
                    break;
            }

            return parentDetails;
        }

        public static Dictionary<string,string> GetBackstory(Character c)
        {
            Dictionary<string, string> _backstory = new Dictionary<string, string>();
            _backstory.Add("Life", GetLifeDetails());
            _backstory.Add("Likes", GetLikesDetails());
            _backstory.Add("Dislikes", GetDislikesDetails());
            _backstory.Add("Quirks", GetQuirkDetails());
            _backstory.Add("Physical Description", GetPhysicalDescription(c));
            _backstory.Add("ParentDetails", GetParents(c));
            return _backstory;
        }

        public static Dictionary<string, string> GetRandomBackstory()
        {
            Character c = new Character();

            Dictionary<string, string> _backstory = new Dictionary<string, string>();
            _backstory.Add("Life", GetLifeDetails());
            _backstory.Add("Likes", GetLikesDetails());
            _backstory.Add("Dislikes", GetDislikesDetails());
            _backstory.Add("Quirks", GetQuirkDetails());
            _backstory.Add("Physical Description", GetPhysicalDescription(c));
            _backstory.Add("ParentDetails", GetParents(c));
            return _backstory;
        }

    }
}
