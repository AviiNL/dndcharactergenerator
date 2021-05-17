using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Stats
{
    public class Charisma : IStat
    {
        public int Value {get;set;}

        public Charisma()
        {
            Value = 0;
        }

        public Charisma(int value)
        {
            Value = value;
        }

        public static implicit operator Charisma(int value)
        {
            return new Charisma(value);
        }

        public static implicit operator int(Charisma d)
        {
            return d.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
