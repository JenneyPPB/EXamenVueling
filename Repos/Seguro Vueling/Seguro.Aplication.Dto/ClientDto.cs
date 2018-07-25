using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguro.Aplication.Dto
{
    public class ClientDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Rol { get; set; }

        public ClientDto() { }

        public ClientDto(int Id, string Name, string Email, string Rol) {

            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
            this.Rol = Rol;



        }
    }
}
