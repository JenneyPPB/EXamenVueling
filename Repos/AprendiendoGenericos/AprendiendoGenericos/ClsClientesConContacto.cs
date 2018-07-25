using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendiendoGenericos
{
    public class ClsClientesConContacto : clsClientesBase
    {
        public ClsClientesConContacto()
        {

              _Direccion = new clsDirecciones();
        }
        public ClsClientesConContacto(int pId, string pNombre, string pClave, string pRFC, int pTipoRegimen,
                               string pNombreContacto, string pTelefono1, string pTelefono2, string pEmail, string pCalle,
                               string pNumeroExterior, string pNumeroInterir, string pColonia, string pMunicipio, string pEstado,
                               string pCP)
        {
            Id = pId;
            Nombre = pNombre;
            RFC = pRFC;
            Clave = pClave;
            TipoRegimen = pTipoRegimen;
            NombreContacto = pNombreContacto;
            Telefono1 = pTelefono1;
            //Telefono2 = pTelefono2;
            Email = pEmail;
            _Direccion = new clsDirecciones();
            Direccion.Calle = pCalle;
            Direccion.NumeroExterior = pNumeroExterior;
            Direccion.NumeroInterior = pNumeroInterir;
            Direccion.Municipio = pMunicipio;
            Direccion.Colonia = pColonia;
            Direccion.Estado = pEstado;
            Direccion.CP = pCP;
            






        }
         public string Telefono1 { get; set; }
         public string Telefono2{ get; set; }
         public string Email  { get; set; }
         private clsDirecciones _Direccion;
         public clsDirecciones Direccion
         {
            get => _Direccion; set => _Direccion = value;
         }
        

    }
    
}
