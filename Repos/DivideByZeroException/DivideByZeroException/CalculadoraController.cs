using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace DivideByZeroException
{
   public  class CalculadoraController 
    {
        private readonly log4net.ILog _logger;
        public CalculadoraController(ILog logger) {
            _logger = loger;

        }
        public int Divide(int num1, int num2) {
             
            try
            {
               int div= num1 / num2
            }
            catch (DivideByZeroException)
            {
                this._logger.Error();
            }
            throw 

        }

         = container.Resolver<CalculadoraController>();
    } 
}
