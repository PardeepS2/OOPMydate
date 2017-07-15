using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMydate
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDate test = new MyDate(2012, 3, 31);
            bool obj;

            obj = test.isLeapYear(2012);
            
            Console.WriteLine(test.nextDay());
            Console.WriteLine(test.nextMonth());
            Console.ReadKey();
        }
    }
}
