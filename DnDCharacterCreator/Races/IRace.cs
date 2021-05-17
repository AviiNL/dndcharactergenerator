using DnDCharacterCreator.Stats;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Races
{
    public interface IRace
    {
        List<IStat> Stats { get; }
        Skill Proficiencies { get; }
        Language Languages { get; }
        int Speed { get; }
    }
}
