using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Database
{
   public class UniversityEntity : DbContext
    {
        public UniversityEntity() {
            System.Data.Entity.Database.SetInitializer(new CreateDatabaseIfNotExists<UniversityEntity>());

        }
         public virtual DbSet<Students> Students { get; set; }
         public virtual DbSet<Teacher>Teachers  { get; set; }
         public virtual DbSet<Subjects> Subjects { get; set; }
         public virtual DbSet<Courses>Courses { get; set; }
    }
}
