using DnDCharacterCreator.Stats;
using System.Collections.Generic;

namespace DnDCharacterCreator.Races
{
    public class Dwarf : IRace
    {
        public Language Languages { get; set; } = Language.Common | Language.Dwarvish;

        public int Speed {
            get {
                return 25;
            }
        }

        public Skill Proficiencies {
            get {
                return 0;
            }
        }

        List<IStat> IRace.Stats {
            get => new List<IStat>()
            {
                { new Charisma(0) },
                { new Constitution(2) },
                { new Dexterity(0) },
                { new Intelligence(0) },
                { new Strength(0) },
                { new Wisdom(0) },
            };
        }
    }
}
