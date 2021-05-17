using DnDCharacterCreator.Classes;
using DnDCharacterCreator.Races;
using DnDCharacterCreator.Stats;
using System;
using System.Linq;

namespace DnDCharacterCreator
{
    public class CharacterSheet
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public IClass Class { get; set; }
        public IRace Race { get; set; }
        public Gender Gender { get; set; }
        public int Proficiency {
            get {
                return Tables.LevelProficiency[Level];
            }
        }

        public int HitPoints { get; set; } = 0;

        public Strength Strength { get; set; } = new Strength();
        public Dexterity Dexterity { get; set; } = new Dexterity();
        public Constitution Constitution { get; set; } = new Constitution();
        public Intelligence Intelligence { get; set; } = new Intelligence();
        public Wisdom Wisdom { get; set; } = new Wisdom();
        public Charisma Charisma { get; set; } = new Charisma();

        public Skill Skills { get; set; }
        public Ability SavingThrows { get; set; }

        public Language Languages { get; set; }

        public void PrintSheet()
        {
            var charisma = Charisma + Race.Stats.First(x => x.GetType() == typeof(Charisma)).Value;
            var constitution = Constitution + Race.Stats.First(x => x.GetType() == typeof(Constitution)).Value;
            var dexterity = Dexterity + Race.Stats.First(x => x.GetType() == typeof(Dexterity)).Value;
            var intelligence = Intelligence + Race.Stats.First(x => x.GetType() == typeof(Intelligence)).Value;
            var strength = Strength + Race.Stats.First(x => x.GetType() == typeof(Strength)).Value;
            var wisdom = Wisdom + Race.Stats.First(x => x.GetType() == typeof(Wisdom)).Value;

            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Gender: {Gender.ToString()}");
            Console.WriteLine($"Race: {Race.GetType().Name}");
            Console.WriteLine($"Class: {Class.GetType().Name}");
            Console.WriteLine($"Level: {Level}");

            Console.WriteLine("");
            Console.WriteLine($"Proficiency: {Proficiency}");

            // Level 1 HP
            HitPoints = (int)Class.HitDie + Tables.AbilityModifier[constitution];

            // Calculate rest of levels
            for (var i = 1; i < Level; i++)
            {
                // for each level, roll a die and add that..
                var roll = RollEngine.Roll(Class.HitDie) + Tables.AbilityModifier[constitution];
                HitPoints += roll;
            }

            Console.WriteLine($"Max Hitpoints: {HitPoints}");

            Console.WriteLine("");
            Console.WriteLine("== Ability Scores ==");

            Console.WriteLine($"Charisma: {Tables.AbilityModifier[charisma]} ({charisma})");
            Console.WriteLine($"Constitution: {Tables.AbilityModifier[constitution]} ({constitution})");
            Console.WriteLine($"Dexterity: {Tables.AbilityModifier[dexterity]} ({dexterity})");
            Console.WriteLine($"Intelligence: {Tables.AbilityModifier[intelligence]} ({intelligence})");
            Console.WriteLine($"Strength: {Tables.AbilityModifier[strength]} ({strength})");
            Console.WriteLine($"Wisdom: {Tables.AbilityModifier[wisdom]} ({wisdom})");

            Console.WriteLine("");
            Console.WriteLine("== Languages ==");
            var languages = Race.Languages | Languages;

            foreach (Enum value in Enum.GetValues(languages.GetType()))
            {
                if (languages.HasFlag(value))
                {
                    Console.WriteLine(value);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("== Saving Throws ==");
            SavingThrows |= Class.SavingThrowProficiencies;
            foreach (Enum value in Enum.GetValues(typeof(Ability)))
            {
                if (SavingThrows.HasFlag(value))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.WriteLine(value);

                if (SavingThrows.HasFlag(value))
                {
                    Console.ResetColor();
                }
            }


            Console.WriteLine("");
            Console.WriteLine("== Skills ==");

            // Get racial/class proficiencies

            foreach (Enum value in Enum.GetValues(Skills.GetType()))
            {
                var type = Modifier.SkillStat[(Skill)value];

                var properties = this.GetType().GetProperties();
                foreach (var property in properties)
                {
                    if (property.PropertyType == type)
                    {
                        if (Skills.HasFlag(value))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"({type.Name.Substring(0, 3)}");
                            Console.Write($" {Tables.AbilityModifier[((IStat)property.GetValue(this)).Value] + Proficiency})");
                            Console.WriteLine($" {value.ToString()}");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write($"({type.Name.Substring(0, 3)}");
                            Console.Write($" {Tables.AbilityModifier[((IStat)property.GetValue(this)).Value]})");
                            Console.WriteLine($" {value.ToString()}");
                        }
                    }
                }
            }
        }
    }
}
