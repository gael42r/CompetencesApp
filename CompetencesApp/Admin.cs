using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetencesApp
{
    public class Admin : User
    {
        public List<Competence> competences { get; set; }
        public List<User> users { get; set; }
        public List<CompetenceBlock> competenceblocks { get; set; }


    }
}
