using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
 


    public class Courses
    {
        public Courses() {

            Students = new HashSet<Students>();//hereda de ICollection

        }




        public int id { get; set; }
        public int TeacherId { get; set; }
        public int SubjectId{ get; set; }
        public  virtual ICollection<Students> Students { get; set; }
       // public  virtual List<Teacher> Teacher { get; set; }
       // public  virtual List <Subjects> Subjects{ get; set;}
        



    }
}
