using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Names
{
    public interface IName
    {
        List<string> Female { get; }
        List<string> Male { get; }
    }
}
