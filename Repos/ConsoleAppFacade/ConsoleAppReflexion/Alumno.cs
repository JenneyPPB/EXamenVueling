using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppReflexion
{
    class Alumno
    {
        public int IdAlumno { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }


        public Alumno()
        {

        }

          public Alumno(int IdAlumno, string Nombre, string Apellidos, string Dni) {

            this.IdAlumno = IdAlumno;
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Dni = Dni;



          }

        
    }
}
