using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Stats
{
    public class Intelligence : IStat
    {
        public int Value { get; set; }

        public Intelligence()
        {
            Value = 0;
        }

        public Intelligence(int value)
        {
            Value = value;
        }

        public static implicit operator Intelligence(int value)
        {
            return new Intelligence(value);
        }

        public static implicit operator int(Intelligence d)
        {
            return d.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
