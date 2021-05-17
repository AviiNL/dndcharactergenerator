using DnDCharacterCreator.Stats;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Races
{
    public class Dragonborn : IRace
    {
        public Language Languages { get; set; } = Language.Common | Language.Draconic;

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
                { new Charisma(1) },
                { new Constitution(0) },
                { new Dexterity(0) },
                { new Intelligence(0) },
                { new Strength(2) },
                { new Wisdom(0) },
            };
        }
    }
}
