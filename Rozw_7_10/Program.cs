using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozw_7_10
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime swieta = new DateTime(DateTime.Now.Year, 12, 24, 17, 0, 0);
            if (swieta > DateTime.Now)
            {
                Console.WriteLine("zostało {0} dni do świąt", swieta.DayOfYear - DateTime.Now.DayOfYear);
            }
            else
            {
                Console.WriteLine("po świętach");
            }
            Console.ReadKey();
        }
    }
}
