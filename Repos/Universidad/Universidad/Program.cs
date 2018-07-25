using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;

namespace Universidad
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var uni = new UniversityEntity())
            {
                uni.Students.ToList();//Listar todos los estudiantes que hayan



            }
        }
    }
}
