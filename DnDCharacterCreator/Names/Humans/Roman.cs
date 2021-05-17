using System;
using System.Collections.Generic;
using System.Text;

namespace DnDCharacterCreator.Names.Humans
{
    public class Roman : IName
    {
        public List<string> Female { get => new List<string>()
        {
            "Aelia", "Aemilia", "Agrippina", "Alba", "Antonia",
            "Aquila", "Augusta", "Aurelia", "Balbina", "Blandina",
            "Caelia", "Camilla", "Casia", "Claudia", "Cloelia",
            "Domitia", "Drusa", "Fabia", "Fabricia", "Fausta",
            "Flavia", "Floriana", "Fulvia", "Germana", "Glaucia",
            "Gratiana", "Hadriana", "Hermina", "Horatia", "Hortensia",
            "Iovita", "Iulia", "Laelia", "Laurentia", "Livia",
            "Longina", "Lucilla", "Lucretia", "Marcella", "Marcia",
            "Maxima", "Nona", "Octavia", "Paulina", "Petronia",
            "Porcia", "Tacita", "Tullia", "Verginia", "Vita",
        };}
        public List<string> Male { get => new List<string>()
        {
            "Aelius", "Aetius", "Agrippa", "Albanus", "Albus",
            "Antonius", "Appius", "Aquilinus", "Atilus", "Augustus",
            "Aurelius", "Avitus", "Balbus", "Blandus", "Blasius",
            "Brutus", "Caelius", "Caius", "Casian", "Cassius",
            "Cato", "Celsus", "Claudius", "Cloelius", "Cnaeus",
            "Crispus", "Cyprianus", "Diocletianus", "Egnatius", "Ennius",
            "Fabricius", "Faustus", "Gaius", "Germanus", "Gnaeus",
            "Horatius", "Iovianus", "Iulius", "Lucilius", "Manius",
            "Marcus", "Marius", "Maximus", "Octavius", "Paulus",
            "Quintilian", "Regulus", "Servius", "Tacitus", "Varius",
        };}

    }
}
