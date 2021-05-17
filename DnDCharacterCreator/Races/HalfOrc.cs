using DnDCharacterCreator.Stats;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Races
{
    public class HalfOrc : IRace
    {
        public Language Languages { get; set; } = Language.Common | Language.Orcish;

        public int Speed {
            get {
                return 30;
            }
        }

        public Skill Proficiencies {
            get {
                return Skill.Intimidation; // Menacing
            }
        }

        List<IStat> IRace.Stats {
            get => new List<IStat>()
            {
                { new Charisma(0) },
                { new Constitution(1) },
                { new Dexterity(0) },
                { new Intelligence(0) },
                { new Strength(2) },
                { new Wisdom(0) },
            };
        }
    }
}
