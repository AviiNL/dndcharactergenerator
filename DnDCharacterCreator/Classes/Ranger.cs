namespace DnDCharacterCreator.Classes
{
    public class Ranger : IClass
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
                return RollEngine.Dice.D10;
            }
        }

        public int SkillNum {
            get {
                return 3;
            }
        }

        public Skill AvailableSkills {
            get {
                return Skill.AnimalHandling | Skill.Athletics | Skill.Insight | Skill.Investigation | Skill.Nature | Skill.Perception | Skill.Stealth | Skill.Survival;
            }
        }
    }
}
