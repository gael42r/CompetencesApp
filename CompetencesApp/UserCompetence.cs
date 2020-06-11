using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetencesApp
{
    public class UserCompetence
    {

        public string _id { get; set; }
        public bool isValidated { get; set; }
        public string competenceId { get; set; }
        public float userPercent { get; set; }
        public float teacherPercent { get; set; }
        public List<Document> doclist { get; set; }
    }
}
