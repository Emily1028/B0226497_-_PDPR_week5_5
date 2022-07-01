using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR_week5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            x = 10;y = 20;z = 15;
            Console.WriteLine("B0226497_段昱如_PDPR_week5_5");
            Console.WriteLine("(1) x = 10,y = 20,z = 15");
            Console.WriteLine("(2) x > y 為" +(x > y));
            Console.WriteLine("(3) x > z 為" + (x > z));
            Console.WriteLine("(4) x < y 為" + (x < y));
            Console.WriteLine("(5) y < z 為" + (y < z));
            Console.WriteLine("(6) x > y && x > z 為" + (x > y && x > z));
            Console.WriteLine("(7) x > y || x > z 為" + (x > y || x > z));
            Console.WriteLine("(8) ! ( x > y ) 為" + (!(x > y)));
            Console.ReadLine();
        }
    }
}
