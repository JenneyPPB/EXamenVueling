using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Database
{
   public class Teacher
    {
        public Teacher() {
            Courses = new HashSet<Courses>();//hereda de ICollection

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        //public virtual List<Courses> Courses { get; set; }// entrelazo teacher con los cursos asi

        public virtual ICollection<Courses> Courses { get; set; }//Asi evidencia la relacion de a muchos o sea un profesor tiene muchos cursos
    }
}
