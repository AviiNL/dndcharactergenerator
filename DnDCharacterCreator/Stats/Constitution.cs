using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Stats
{
    public class Constitution : IStat
    {
        public int Value { get; set; }

        public Constitution()
        {
            Value = 0;
        }

        public Constitution(int value)
        {
            Value = value;
        }

        public static implicit operator Constitution(int value)
        {
            return new Constitution(value);
        }

        public static implicit operator int(Constitution d)
        {
            return d.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
