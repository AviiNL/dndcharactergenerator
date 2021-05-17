using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Classes
{
    public class Barbarian : IClass
    {
        public Ability PrimaryAbility {
            get {
                return Ability.Strength;
            }
        }

        public Ability SavingThrowProficiencies {
            get {
                return Ability.Strength | Ability.Constitution;
            }
        }

        public RollEngine.Dice HitDie {
            get {
                return RollEngine.Dice.D12;
            }
        }

        public int SkillNum {
            get {
                return 2;
            }
        }

        public Skill AvailableSkills {
            get {
                return Skill.AnimalHandling | Skill.Athletics | Skill.Intimidation | Skill.Nature | Skill.Perception | Skill.Survival;
            }
        }
    }
}
