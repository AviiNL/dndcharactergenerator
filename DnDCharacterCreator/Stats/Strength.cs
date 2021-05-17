using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Stats
{
    public class Strength : IStat
    {
        public int Value { get; set; }

        public Strength()
        {
            Value = 0;
        }

        public Strength(int value)
        {
            Value = value;
        }

        public static implicit operator Strength(int value)
        {
            return new Strength(value);
        }

        public static implicit operator int(Strength d)
        {
            return d.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
