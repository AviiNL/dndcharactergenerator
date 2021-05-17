using System.Collections.Generic;

namespace DnDCharacterCreator.Names
{
    internal class HalfElf : IName
    {
        public List<string> Male { get; }
        public List<string> Female { get; }
        public List<string> Family { get; }

        public HalfElf()
        {
            Male = new List<string>();
            Female = new List<string>();
            Family = new List<string>();

            Male.AddRange(new Human().Male);
            Male.AddRange(new Elf().Male);

            Female.AddRange(new Human().Female);
            Female.AddRange(new Elf().Female);

            Family.AddRange(new Elf().Family);

        }

    }
}
