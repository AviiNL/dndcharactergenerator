namespace DnDCharacterCreator.Classes
{
    public class Sorcerer : IClass
    {
        public Ability PrimaryAbility {
            get {
                return Ability.Charisma;
            }
        }

        public Ability SavingThrowProficiencies {
            get {
                return Ability.Charisma | Ability.Constitution;
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
                return Skill.Arcana | Skill.Deception | Skill.Insight | Skill.Intimidation | Skill.Persuasion | Skill.Religion;
            }
        }
    }
}
