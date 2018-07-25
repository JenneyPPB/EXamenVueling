using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleReflexion
{
    public class Cancion
    {
        public Cancion(string titulo, string genero, string interprete, string fecha)
        {
            Titulo = titulo;
            Genero = genero;
            Interprete = interprete;
            Fecha = fecha;
        }

        public string Titulo { get; set; }
        public string Genero{ get; set; }
        public  string Interprete{ get; set; }
        public string Fecha{ get; set; }

    }
}
