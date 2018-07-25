using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectGrapadora
{
     public class Fotocopia
    {
        public string Tipodocumento { get; set; }
        public int CantidadCopias { get; set; }
        public int Precio{ get; set; }
     
         
        public Fotocopia() {



        }
        public Fotocopia(string TipoDocumento,int CantidadCopias,int Precio) {

            this.Tipodocumento = Tipodocumento;
            this.CantidadCopias = CantidadCopias;
            this.Precio = Precio;

        }
    }
}
