using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veling.Common.Layer
{
    public class VuelingException : Exception
    {
        
        
            public VuelingException()
            {
            }

            public VuelingException(string message)// el parametro tiene que coincidir    con el parametro de la clase base
                : base(message)
            {
            }

            public VuelingException(string message, Exception inner)
                : base(message, inner)
            {
            }
         

    }
}
