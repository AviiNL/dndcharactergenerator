using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator
{
    [Flags]
    public enum Language
    {
        Common = 0,
        Elvish = 1,
        Dwarvish = 2,
        Halfling = 4,
        Orcish = 8,
        Draconic = 16,
        Gnomish = 32,
        Infernal = 64,
        Giant = 128,
        Goblin = 256,
        Abyssal = 512,
        Celestial = 1024,
        DeepSpeech = 2048,
        Primordial = 4096,
        Sylvan = 8192,
        Undercommon = 16384,
    }
}
