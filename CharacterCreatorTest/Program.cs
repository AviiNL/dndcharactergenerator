using DnDCharacterCreator;
using DnDCharacterCreator.Classes;
using DnDCharacterCreator.Names;
using DnDCharacterCreator.Races;
using DnDCharacterCreator.Stats;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CharacterCreatorTest
{
    internal class Program
    {
        private static Random rnd = new Random();

        private static void Main(string[] args)
        {
            while (true)
            {
                Gender gender = (Gender)rnd.Next(1, 2);

                var a = typeof(IRace).Assembly.GetTypes();

                List<Type> races = new List<Type>();
                foreach (var c in a)
                {
                    if (c.Namespace != "DnDCharacterCreator.Races" || c.IsAbstract || c.IsInterface)
                    {
                        continue;
                    }

                    races.Add(c);
                }
                var raceType = races[rnd.Next(0, races.Count)];
                IRace race = Activator.CreateInstance(raceType) as IRace;

                List<Type> classes = new List<Type>();
                foreach (var c in a)
                {
                    if (c.Namespace != "DnDCharacterCreator.Classes" || c.IsAbstract || c.IsInterface)
                    {
                        continue;
                    }

                    classes.Add(c);
                }
                var classType = classes[rnd.Next(0, classes.Count)];
                IClass _class = Activator.CreateInstance(classType) as IClass;

                var nameType = typeof(IRace).Assembly.GetType($"DnDCharacterCreator.Names.{race.GetType().Name}");
                IName nameInstance = Activator.CreateInstance(nameType) as IName;

                string name = nameInstance.Male[rnd.Next(0, nameInstance.Male.Count - 1)];
                if (gender == Gender.Female)
                {
                    name = nameInstance.Male[rnd.Next(0, nameInstance.Female.Count - 1)];
                }

                // TODO: Family / Clan / Virtue
                if(nameType.GetProperty("Family") != null)
                {
                    var family_names = (List<string>)nameType.GetProperty("Family").GetValue(nameInstance);
                    name += $" {family_names[rnd.Next(0, family_names.Count - 1)]}";
                }

                if (nameType.GetProperty("Clan") != null)
                {
                    var family_names = (List<string>)nameType.GetProperty("Clan").GetValue(nameInstance);
                    name += $" of {family_names[rnd.Next(0, family_names.Count - 1)]}";
                }

                if (nameType.GetProperty("Virtue") != null)
                {
                    var family_names = (List<string>)nameType.GetProperty("Virtue").GetValue(nameInstance);
                    name += $" of the {family_names[rnd.Next(0, family_names.Count - 1)]}";
                }

                var charisma = new List<int>();
                var constitution = new List<int>();
                var dexterity = new List<int>();
                var intelligence = new List<int>();
                var strength = new List<int>();
                var wisdom = new List<int>();

                for (int i = 0; i < 4; i++)
                {
                    charisma.Add(RollEngine.Roll(RollEngine.Dice.D6));
                    constitution.Add(RollEngine.Roll(RollEngine.Dice.D6));
                    dexterity.Add(RollEngine.Roll(RollEngine.Dice.D6));
                    intelligence.Add(RollEngine.Roll(RollEngine.Dice.D6));
                    strength.Add(RollEngine.Roll(RollEngine.Dice.D6));
                    wisdom.Add(RollEngine.Roll(RollEngine.Dice.D6));
                }

                charisma = charisma.OrderByDescending(i => i).ToList();
                constitution = constitution.OrderByDescending(i => i).ToList();
                dexterity = dexterity.OrderByDescending(i => i).ToList();
                intelligence = intelligence.OrderByDescending(i => i).ToList();
                strength = strength.OrderByDescending(i => i).ToList();
                wisdom = wisdom.OrderByDescending(i => i).ToList();

                CharacterSheet sheet = new CharacterSheet()
                {
                    Name = name,
                    Race = race,
                    Class = _class,
                    Gender = gender,
                    Level = 1,
                    Charisma = charisma.Take(3).Sum(),
                    Constitution = constitution.Take(3).Sum(),
                    Dexterity = dexterity.Take(3).Sum(),
                    Intelligence = intelligence.Take(3).Sum(),
                    Strength = strength.Take(3).Sum(),
                    Wisdom = wisdom.Take(3).Sum(),
                };

                // if human, add one random language
                if (race.GetType() == typeof(DnDCharacterCreator.Races.Human) || race.GetType() == typeof(HalfElf))
                {
                    var values = Enum.GetValues(typeof(Language));
                    sheet.Languages |= (Language)values.GetValue(rnd.Next(1, values.Length));
                }

                if (race.GetType() == typeof(HalfElf))
                {
                    // add a point to 2 random ability scores
                    List<Type> stats = new List<Type>();
                    foreach (var c in a)
                    {
                        if (c.Namespace != "DnDCharacterCreator.Stats" || c.IsAbstract || c.IsInterface)
                        {
                            continue;
                        }
                        stats.Add(c);
                    }

                    stats.Shuffle();
                    foreach (var s in stats.Take(2))
                    {
                        var p = typeof(CharacterSheet).GetProperty(s.Name);
                        var newval = Activator.CreateInstance(p.PropertyType, ((IStat)p.GetValue(sheet)).Value + 1);
                        p.SetValue(sheet, newval);
                    }

                    // Add 2 random skills
                    Enum.GetValues(typeof(Skill)).Cast<Skill>().OrderBy(x => rnd.Next()).Take(2).ToList().ForEach(x => sheet.Skills |= x);
                }


                var skillList = _class.AvailableSkills.GetFlags().ToList();

                for (int i = 0; i < _class.SkillNum; i++)
                {
                    skillList.Shuffle();
                    var skill = skillList.Take(1).First();

                    sheet.Skills |= (Skill)skill;
                    skillList.Remove(skill);
                }


                sheet.PrintSheet();

                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("===================");
                Console.WriteLine();
            }
        }
    }
}
