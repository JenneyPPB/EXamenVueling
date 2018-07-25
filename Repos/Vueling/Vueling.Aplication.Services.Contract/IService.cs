using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Infraestruccure.Repository.Contract
{
   public interface  IService<T>
    {
        T Add(T model);// me puede devolver T o un entero

        T Update(T model);

        List<T> GetAll();

        List<T> GetById(int id);


        int Remove(int id);
    }
}
