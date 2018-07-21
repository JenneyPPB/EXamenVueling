using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Aplication.Service.Contract
{
   public interface IRepository <T>
    {
        T Add(T model);
        T Update(T model);
        List<T> GetAll();
        T GetById(int Id);
        int Remove(int Id);

    }
}
