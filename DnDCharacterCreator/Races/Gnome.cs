using DnDCharacterCreator.Stats;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Races
{
    public class Gnome : IRace
    {
        public Language Languages { get; set; } = Language.Common;

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
                { new Constitution(0) },
                { new Dexterity(0) },
                { new Intelligence(2) },
                { new Strength(0) },
                { new Wisdom(0) },
            };
        }
    }
}
