using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Aplication.Service.Contract
   internal class IClientService <T> : IIClientService
{
    public IClientService()
    {
    }

        T  Add(T DBModels);
        T Update(T DBModels);
        List<T> GetAll();
        T GetById(int Id);
        int Remove(int Id);

    public override string ToString()
    {
        return base.ToString();
    }

    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}
}
