using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new bluewindsEntities())//Se instancia el customer
            {

                var lastWeekOrders = context
                .Orders
                .Where(order => order.Customer.FirstName == "Ana" && order.Customer.LastName == "Trujillo")
                .OrderBy(x => x.TotalAmount)
                .ToList();

                foreach (var order in lastWeekOrders)
                {
                    Console.WriteLine($"{order.Id} + Date: {order.OrderDate} + Amount: {order.TotalAmount}");


                }


            }
        }
    }
}
