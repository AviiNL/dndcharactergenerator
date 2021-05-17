namespace DnDCharacterCreator.Classes
{
    public class Bard : IClass
    {
        public Ability PrimaryAbility {
            get {
                return Ability.Charisma;
            }
        }

        public Ability SavingThrowProficiencies {
            get {
                return Ability.Dexterity | Ability.Charisma;
            }
        }

        public RollEngine.Dice HitDie {
            get {
                return RollEngine.Dice.D8;
            }
        }

        public int SkillNum {
            get {
                return 3;
            }
        }

        public Skill AvailableSkills {
            get {
                return Skill.Acrobatics |
                    Skill.AnimalHandling |
                    Skill.Arcana |
                    Skill.Athletics |
                    Skill.Deception |
                    Skill.History |
                    Skill.Insight |
                    Skill.Intimidation |
                    Skill.Investigation |
                    Skill.Medicine |
                    Skill.Nature |
                    Skill.Perception |
                    Skill.Performance |
                    Skill.Persuasion |
                    Skill.Religion |
                    Skill.SleightOfHand |
                    Skill.Stealth |
                    Skill.Survival;
            }
        }
    }
}
