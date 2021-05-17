using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Classes
{
    public class Paladin : IClass
    {
        public Ability PrimaryAbility {
            get {
                return Ability.Strength | Ability.Charisma;
            }
        }

        public Ability SavingThrowProficiencies {
            get {
                return Ability.Wisdom | Ability.Charisma;
            }
        }

        public RollEngine.Dice HitDie {
            get {
                return RollEngine.Dice.D10;
            }
        }

        public int SkillNum {
            get {
                return 2;
            }
        }

        public Skill AvailableSkills {
            get {
                return Skill.Athletics | Skill.Insight | Skill.Intimidation | Skill.Medicine | Skill.Persuasion | Skill.Religion;
            }
        }
    }
}
