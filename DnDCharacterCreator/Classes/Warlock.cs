namespace DnDCharacterCreator.Classes
{
    public class Warlock : IClass
    {
        public Ability PrimaryAbility {
            get {
                return Ability.Charisma;
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
                return Skill.Arcana | Skill.Deception | Skill.History | Skill.Intimidation | Skill.Investigation | Skill.Nature | Skill.Religion;
            }
        }
    }
}
