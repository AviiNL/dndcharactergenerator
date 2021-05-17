using System;

namespace DnDCharacterCreator.Classes
{
    public class Fighter : IClass
    {
        public Ability PrimaryAbility {
            get {
                return new Random().Next(0, 1) == 0 ? Ability.Strength : Ability.Dexterity;
            }
        }

        public Ability SavingThrowProficiencies {
            get {
                return Ability.Strength | Ability.Constitution;
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
                return Skill.Acrobatics | Skill.AnimalHandling | Skill.Athletics | Skill.History | Skill.Insight | Skill.Intimidation |
                    Skill.Perception | Skill.Survival;
            }
        }
    }
}
