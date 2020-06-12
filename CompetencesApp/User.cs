using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetencesApp
{
    public class User
    {
        public List<Promotion> promos { get; set; }
        public List<UserCompetence> comps { get; set; }
        public string _id { get; set; }
        public string firstName { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string surname { get; set; }

        public string salt { get; set; }
        public bool isAdmin { get; set; }

        public bool isTeacher { get; set; }


        public User()
        {

        }

    }
}
