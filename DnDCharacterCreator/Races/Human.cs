using DnDCharacterCreator.Stats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DnDCharacterCreator.Races
{
    public class Human : IRace
    {
        public Language Languages { get; set; } = Language.Common;

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
                { new Constitution(1) },
                { new Dexterity(1) },
                { new Intelligence(1) },
                { new Strength(1) },
                { new Wisdom(1) },
            };
        }
    }
}
