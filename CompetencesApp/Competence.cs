﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetencesApp
{
    public class Competence
    {
        public List<Resource> ressources { get; set; }

        public string _id { get; set; }
        public string name { get; set; }
        public string description { get; set; }


    }
}
