using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguro.Infraestructure.Repository.Contract
{
  public  interface IRepository <T>
    {
        T Add(T model);
        T Update(Task model);
        List<T> GetAll();
        T GetTById(int id);
        int Remove(int id);
    }
}
