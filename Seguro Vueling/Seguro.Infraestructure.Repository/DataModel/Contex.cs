using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Seguro.Infraestructure.Repository.DataModel
{
    public  class Contex : DbContext
    {
        public DbSet<Client> clientes { get; set; }
        public DbSet<Poliza> polizas { get; set; }
    }
}
