using DnDCharacterCreator.Stats;
using System.Collections.Generic;

namespace DnDCharacterCreator.Races
{
    public class Thiefling : IRace
    {
        public Language Languages { get; set; } = Language.Common | Language.Infernal;

        public int Speed {
            get {
                return 30;
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
                { new Charisma(2) },
                { new Constitution(0) },
                { new Dexterity(0) },
                { new Intelligence(1) },
                { new Strength(0) },
                { new Wisdom(0) },
            };
        }
    }
}
