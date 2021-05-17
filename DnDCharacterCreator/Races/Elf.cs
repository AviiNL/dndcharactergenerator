using DnDCharacterCreator.Stats;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Races
{
    public class Elf : IRace
    {
        public Language Languages { get; set; } = Language.Common | Language.Elvish;

        public int Speed {
            get {
                return 30;
            }
        }

        public Skill Proficiencies {
            get {
                return Skill.Perception; // Keen Senses
            }
        }

        List<IStat> IRace.Stats {
            get => new List<IStat>()
            {
                { new Charisma(0) },
                { new Constitution(0) },
                { new Dexterity(2) },
                { new Intelligence(0) },
                { new Strength(0) },
                { new Wisdom(0) },
            };
        }
    }
}
