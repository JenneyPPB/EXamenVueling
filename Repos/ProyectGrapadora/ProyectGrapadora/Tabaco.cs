using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectGrapadora
{
    public class Tabaco
    {
        public string Marca { get; set; }
        public int Precio { get; set; }

        public Tabaco() {


        }
        public Tabaco(string marca, int precio) {
            this.Marca = Marca;
            this.Precio = Precio;


        }
        
    }
}
