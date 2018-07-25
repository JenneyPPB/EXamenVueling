using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Students
    {
        public Students() {
            Courses = new HashSet<Courses>();//hashset es el tipo de datos que utiliza entity para gardar informacion

        }
        public int  Id { get; set; }
        public string FirstName  { get; set; }
        public string LastName{ get; set; }
        public DateTime Fecha { get; set; }
        public virtual ICollection <Courses> Courses { get; set; }//Para poder enlazar

    }
}
