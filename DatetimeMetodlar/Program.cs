using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatetimeMetodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            // Su anki zamani almak icin 

            Console.WriteLine(DateTime.Now);

            //Uzun tarih formati icin
            Console.WriteLine(DateTime.Now.ToLongDateString());
            

            //Kisa Tarih icin 
            Console.WriteLine(DateTime.Now.ToShortDateString());

            // Tarih formatlama 

            Console.WriteLine(DateTime.Now.Day+"/"+ DateTime.Now.Month+"/"+ DateTime.Now.Year);


            // Artik yil Kontrolu

            bool artikYil = DateTime.IsLeapYear(1998);
            Console.WriteLine(artikYil==true?"Subat 29 Gundur":"Subat 28 Gundur");


            //Haftanin Gunu

            Console.WriteLine(DateTime.Now.DayOfWeek);

            //Yilin Kacinci Gunu
            Console.WriteLine(DateTime.Now.DayOfYear);



            //Timespan : İki zaman arasindaki farki size verir

            DateTime dogumgunu = new DateTime(1990, 1, 1);

            TimeSpan span = DateTime.Now - dogumgunu;

            double toplamgun = span.TotalDays;
            Console.WriteLine($"Toplam Gun:{toplamgun}");
            Console.ReadLine();

        }
    }
}
