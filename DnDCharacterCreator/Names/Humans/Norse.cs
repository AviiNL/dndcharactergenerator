using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Names.Humans
{
    public class Norse : IName
    {
        public List<string> Female { get => new List<string>()
        {
            "Alfhild", "Arnbjorg", "Ase", "Aslog", "Astrid",
            "Auda", "Audhid", "Bergljot", "Birghild", "Bodil",
            "Brenna", "Brynhild", "Dagmar", "Eerika", "Eira",
            "Gudrun", "Gunborg", "Gunhild", "Gunvor", "Helga",
            "Hertha", "Hilde", "Hillevi", "Ingrid", "Iona",
            "Jorunn", "Kari", "Kenna", "Magnhild", "Nanna",
            "Olga", "Ragna", "Ragnhild", "Ranveig", "Runa",
            "Saga", "Sigfrid", "Signe", "Sigrid", "Sigrunn",
            "Solveg", "Svanhild", "Thora", "Torborg", "Torunn",
            "Tove", "Unn", "Vigdis", "Ylva", "Yngvild",
        };}
        public List<string> Male { get => new List<string>()
        {
            "Agni", "Alaric", "Anvindr", "Arvid", "Asger",
            "Asmund", "Bjarte", "Bjorg", "Bjorn", "Brandr",
            "Brandt", "Brynjar", "Calder", "Colborn", "Cuyler",
            "Egil", "Einar", "Eric", "Erland", "Fiske",
            "Folkvar", "Fritjof", "Frede", "Geir", "Halvar",
            "Hemming", "Hjalmar", "Hjortr", "Ingimarr", "Ivar",
            "Knud", "Leif", "Liufr", "Manning", "Oddr",
            "Olin", "Ormr", "Ove", "Rannulfr", "Sigurd",
            "Skari", "Snorri", "Sten", "Stigandr", "Stigr",
            "Sven", "Trygve", "Ulf", "Vali", "Vidar",
        };}

    }
}
