using System;

namespace DnDCharacterCreator
{
    [Flags]
    public enum Ability
    {
        Strength = 1,
        Dexterity = 2,
        Constitution = 4,
        Intelligence = 8,
        Wisdom = 16,
        Charisma = 32
    }
}
