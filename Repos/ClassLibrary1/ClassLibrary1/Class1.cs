using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Clas

        DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(json);

        DataTable dataTable = dataSet.Tables["Table1"];

        Console.WriteLine(dataTable.Rows.Count);
// 2

foreach (DataRow row in dataTable.Rows)
{
    Console.WriteLine(row["id"] + " - " + row["item"]);
}
}
}
