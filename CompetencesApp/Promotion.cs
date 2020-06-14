using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetencesApp
{
    public class Promotion
    {
        public string name { get; set; }
        public string _id { get; set; }

        public List<User> users { get; set; }

        public List<string> competenceBlock { get; set; }
    }


}
