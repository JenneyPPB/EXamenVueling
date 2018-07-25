using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Application.Services.Contracts
{
    public interface IRepository<T>
    {
        T Add(T model);
        T Update(T model);
        List<T> GetAll();
        T GetById(int Id);
        int Remove(int Id);
    }
}
