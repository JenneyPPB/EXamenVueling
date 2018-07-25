using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandaFruits
{
    class Program
    {
        private delegate int operador(int i);
            
        static void Main(string[] args)  
        {

            List<string> fruits = new List<string>();
            fruits.Add("apple");
            fruits.Add("banano");
            fruits.Add("pineaple");
            fruits.Add("orange");
            
           // Console.WriteLine(fruits.Find(f => f.Length == 5));
            IEnumerable<string> nfruits = fruits.Where(f => f.Length > 5);
            foreach (string s in nfruits);
           
            Console.WriteLine(s);
            Console.Read();
        }
    }
}
