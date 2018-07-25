using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Landa
{
    class Program
    {
        delegate int operacion(int i);
        static void Main(string[] args)
        {
            operacion square = x => x * x;
            Console.WriteLine(square(3));
            Console.ReadLine();
        }
    }
}
