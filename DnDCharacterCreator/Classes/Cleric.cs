using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Classes
{
    public class Cleric : IClass
    {
        public Ability PrimaryAbility {
            get {
                return Ability.Wisdom;
            }
        }

        public Ability SavingThrowProficiencies {
            get {
                return Ability.Wisdom | Ability.Charisma;
            }
        }

        public RollEngine.Dice HitDie {
            get {
                return RollEngine.Dice.D8;
            }
        }

        public int SkillNum {
            get {
                return 2;
            }
        }

        public Skill AvailableSkills {
            get {
                return Skill.History | Skill.Insight | Skill.Medicine | Skill.Persuasion | Skill.Religion;
            }
        }
    }
}
