using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Names.Humans
{
    public class English : IName
    {
        public List<string> Female { get => new List<string>()
        {
            "Adelaide", "Agatha", "Agnes", "Alice", "Aline",
            "Anne", "Avelina", "Avice", "Beatrice", "Cecily",
            "Egelina", "Eleanor", "Elizabeth", "Ella", "Eloise",
            "Elysande", "Emeny", "Emma", "Emmeline", "Ermina",
            "Eva", "Galiena", "Geva", "Giselle", "Griselda",
            "Hadwisa", "Helen", "Herleva", "Hugolina", "Ida",
            "Isabella", "Jacoba", "Jane", "Joan", "Juliana",
            "Katherine", "Margery", "Mary", "Matilda", "Maynild",
            "Millicent", "Oriel", "Rohesia", "Rosalind", "Rosamund",
            "Sarah", "Susannah", "Sybil", "Williamina", "Yvonne",
        };}
        public List<string> Male { get => new List<string>()
        {
            "Adam", "Adelard", "Aldous", "Anselm", "Arnold",
            "Bernard", "Bertram", "Charles", "Clerebold", "Conrad",
            "Diggory", "Drogo", "Everard", "Frederick", "Geoffrey",
            "Gerald", "Gilbert", "Godfrey", "Gunter", "Guy",
            "Henry", "Heward", "Hubert", "Hugh", "Jocelyn",
            "John", "Lance", "Manfred", "Miles", "Nicholas",
            "Norman", "Odo", "Percival", "Peter", "Ralf",
            "Randal", "Raymond", "Reynard", "Richard", "Robert",
            "Roger", "Roland", "Rolf", "Simon", "Theobald",
            "Theodoric", "Thomas", "Timm", "William", "Wymar",
        };}

    }
}
