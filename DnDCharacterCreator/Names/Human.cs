using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DnDCharacterCreator.Names
{
    public class Human : IName
    {
        public List<string> Male { get; }
        public List<string> Female { get; }

        public string Ethnicity { get; }

        Random rnd = new Random();

        public Human()
        {
            var q = (from t in this.GetType().Assembly.GetTypes()
                     where t.IsClass && t.Namespace == "DnDCharacterCreator.Names.Humans"
                     select t).ToList();

            var nameType = q[rnd.Next(0, q.Count - 1)];

            Ethnicity = nameType.Name;

            IName nameInstance = Activator.CreateInstance(nameType) as IName;

            Male = nameInstance.Male;
            Female = nameInstance.Female;
        }
    }
}
