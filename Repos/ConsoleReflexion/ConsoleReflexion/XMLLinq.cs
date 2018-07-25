using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Xml.Linq;

using System.Xml;


namespace ConsoleReflexion
{
    class XMLLinq
    {

        Assembly myAssembly = typeof(Program).Assembly;
        XElement xmlcancion =XElement.Load(@"c: \users\jbarrios\Source\Repos\ConsoleReflexion\ConsoleReflexion\Musica.xml");
        
        
        //XmlDocument xDoc = new XmlDocument();
        //xDoc.Load(@"c:\users\jbarrios\Source\Repos\ConsoleReflexion\ConsoleReflexion\Musica.xml" );

    }
}
