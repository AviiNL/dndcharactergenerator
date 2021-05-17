namespace DnDCharacterCreator.Classes
{
    public class Wizard : IClass
    {
        public Ability PrimaryAbility {
            get {
                return Ability.Intelligence;
            }
        }

        public Ability SavingThrowProficiencies {
            get {
                return Ability.Intelligence | Ability.Wisdom;
            }
        }

        public RollEngine.Dice HitDie {
            get {
                return RollEngine.Dice.D6;
            }
        }

        public int SkillNum {
            get {
                return 2;
            }
        }

        public Skill AvailableSkills {
            get {
                return Skill.Arcana | Skill.History | Skill.Insight | Skill.Investigation | Skill.Medicine | Skill.Religion;
            }
        }
    }
}
