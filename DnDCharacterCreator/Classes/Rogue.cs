namespace DnDCharacterCreator.Classes
{
    public class Rogue : IClass
    {
        public Ability PrimaryAbility {
            get {
                return Ability.Dexterity;
            }
        }

        public Ability SavingThrowProficiencies {
            get {
                return Ability.Intelligence | Ability.Dexterity;
            }
        }

        public RollEngine.Dice HitDie {
            get {
                return RollEngine.Dice.D8;
            }
        }

        public int SkillNum {
            get {
                return 4;
            }
        }

        public Skill AvailableSkills {
            get {
                return Skill.Acrobatics | Skill.Athletics | Skill.Deception | Skill.Insight | Skill.Intimidation | Skill.Investigation | Skill.Perception | Skill.Performance | Skill.Persuasion | Skill.SleightOfHand | Skill.Stealth;
            }
        }
    }
}
