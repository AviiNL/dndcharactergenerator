using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Classes
{
    public class Monk : IClass
    {
        public Ability PrimaryAbility {
            get {
                return Ability.Wisdom | Ability.Dexterity;
            }
        }

        public Ability SavingThrowProficiencies {
            get {
                return Ability.Strength | Ability.Dexterity;
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
                return Skill.Acrobatics | Skill.Athletics | Skill.History | Skill.Insight | Skill.Religion | Skill.Stealth;            }
        }
    }
}
