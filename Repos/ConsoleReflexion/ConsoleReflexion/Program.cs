using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Xml.Linq ;
using System.Threading.Tasks;
using System.Xml;


namespace ConsoleReflexion
{
    public class Program
    {
        static void Main(string[] args)
        {
            Assembly myAssembly = typeof(Program).Assembly;
            XmlDocument xmlcancion = new XmlDocument();
            xmlcancion.Load(@"c:\users\jbarrios\Source\Repos\ConsoleReflexion\ConsoleReflexion\Musica.xml");
            
        }

    }
}