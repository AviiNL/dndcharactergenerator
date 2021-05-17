namespace DnDCharacterCreator.Classes
{
    public class Druid : IClass
    {
        public Ability PrimaryAbility {
            get {
                return Ability.Wisdom;
            }
        }

        public Ability SavingThrowProficiencies {
            get {
                return Ability.Intelligence | Ability.Wisdom;
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
                return Skill.Arcana | Skill.AnimalHandling | Skill.Insight | Skill.Medicine | Skill.Nature | Skill.Perception | Skill.Religion | Skill.Survival;
            }
        }
    }
}
