using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace AgregandoElementosArchivosXml
{
    public class Program
    {
        static void Main(string[] args)
        {

            XmlDocument docDatos = new XmlDocument();
            docDatos.Load(@"c:\users\jbarrios\Source\Repos\AgregandoElementosArchivosXml\AgregandoElementosArchivosXml\XMLFile1.xml");
        }

        


    }
}
