using Burak_CoreEntityCodeFirst.DataContext;
using Burak_CoreEntityCodeFirst.Entity;
using System;
using System.Linq;

namespace EntityCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CoreDbContext())
            {
                // Insert_Sorgulari.sql'i PostgreSQL icinde calistirip ornek data doldulabilirsiniz.

                foreach (var product in db.Products)
                {
                    Console.WriteLine(product.ToString());
                }

                Console.WriteLine("\n\nSADECE ACTIVE OLANLAR ===========");
                foreach (var product in db.Products.Where(p => p.IsActive))
                {
                    Console.WriteLine(product.ToString());
                }
            }

            Console.ReadKey();
        }
    }
}
