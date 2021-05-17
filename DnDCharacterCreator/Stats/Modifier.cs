using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Stats
{
    public static class Modifier
    {
        public static Dictionary<Skill, Type> SkillStat = new Dictionary<Skill, Type>()
        {
            { Skill.Acrobatics, typeof(Dexterity) },
            { Skill.AnimalHandling, typeof(Wisdom) },
            { Skill.Arcana, typeof(Intelligence) },
            { Skill.Athletics, typeof(Strength) },
            { Skill.Deception, typeof(Charisma) },
            { Skill.History, typeof(Intelligence) },
            { Skill.Insight, typeof(Wisdom) },
            { Skill.Intimidation, typeof(Charisma) },
            { Skill.Investigation, typeof(Intelligence) },
            { Skill.Medicine, typeof(Wisdom) },
            { Skill.Nature, typeof(Intelligence) },
            { Skill.Perception, typeof(Wisdom) },
            { Skill.Performance, typeof(Charisma) },
            { Skill.Persuasion, typeof(Charisma) },
            { Skill.Religion, typeof(Intelligence) },
            { Skill.SleightOfHand, typeof(Dexterity) },
            { Skill.Stealth, typeof(Dexterity) },
            { Skill.Survival, typeof(Wisdom) },
        };
        
    }
}
