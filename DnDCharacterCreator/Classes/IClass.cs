using static DnDCharacterCreator.RollEngine;

namespace DnDCharacterCreator.Classes
{
    public interface IClass
    {
        Dice HitDie { get; }
        Ability PrimaryAbility { get; }
        Ability SavingThrowProficiencies { get; }

        int SkillNum { get; }
        Skill AvailableSkills { get; }
    }
}
