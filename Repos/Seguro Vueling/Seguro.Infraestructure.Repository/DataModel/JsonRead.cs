using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Data;


namespace Seguro.Infraestructure.Repository.DataModel
{
    public class JsonRead 
    {
        //private static DBModels db;
        public void Json()
        {

            //DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(http://www.mocky.io/v2/5808862710000087232b7);
            // = dataSet.Tables["Client"];
            // read file into a string and deserialize JSON to a type
            //Client client = JsonConvert.DeserializeObject<Client>(File.ReadAllText(@"http://www.mocky.io/v2/5808862710000087232b7"));

            // deserialize JSON directly from a file
            /*using (StreamReader file = File.OpenText(@"c:\movie.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                Client client2 = (client)serializer.Deserialize(file, typeof(Client));
            }*/
            
        }
    }
}
