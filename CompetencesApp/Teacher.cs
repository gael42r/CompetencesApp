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

        public Teacher()
        {

        }
        public Teacher(User user)
        {
            this._id = user._id;
            this.firstName = user.firstName;
            this.username = user.username;
            this.password = user.password;
            this.surname = user.surname;
            this.salt = user.salt;
            this.isAdmin = user.isAdmin;
            this.isTeacher = user.isTeacher;
        }
    }

    
}
