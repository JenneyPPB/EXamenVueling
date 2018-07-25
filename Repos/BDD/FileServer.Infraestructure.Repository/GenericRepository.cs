using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileServer.Infraestructure.Repository
{
    public abstract class GenericRepository<T> where T: EntityModel
    {
        protected List<T> Entities { get; set; }
        public GenericRepository() {

            Entities = new List<T>();

        }
        public T Insert(T entity) {

            entity.Id = GetNewId();
            Entities.Add(entity);
            return entity;
        }

        protected int GetNewId() {

            int lastId = 0;
            foreach (var entity in Entities) {

                lastId = lastId > entity.Id 
                    ? lastId : entity.Id;
            }
            return ++lastId;

        }

    }
}
