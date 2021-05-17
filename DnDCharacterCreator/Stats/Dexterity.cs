using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Stats
{
    public class Dexterity : IStat
    {
        public int Value { get; set; }

        public Dexterity()
        {
            Value = 0;
        }

        public Dexterity(int value)
        {
            Value = value;
        }

        public static implicit operator Dexterity(int value)
        {
            return new Dexterity(value);
        }

        public static implicit operator int(Dexterity d)
        {
            return d.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
