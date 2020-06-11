using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetencesApp
{
    public class Competence
    {
        public List<Ressource> ressources { get; set; }

        public string _id;
        public string name;
        public string description;
    }
}
