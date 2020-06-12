using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetencesApp
{
    public class CompetenceBlock
    {
        public List<Competence> competence { get; set; }
        public  string _id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
