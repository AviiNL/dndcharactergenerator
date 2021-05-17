namespace DnDCharacterCreator.Stats
{
    public class Wisdom : IStat
    {
        public int Value { get; set; }

        public Wisdom()
        {
            Value = 0;
        }

        public Wisdom(int value)
        {
            Value = value;
        }

        public static implicit operator Wisdom(int value)
        {
            return new Wisdom(value);
        }

        public static implicit operator int(Wisdom d)
        {
            return d.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
