using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetencesApp
{
    public class Teacher : User
    {
        public List<Competence> teacherCompetence { get; set; }

    }
}
