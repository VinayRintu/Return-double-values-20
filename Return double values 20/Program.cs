using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_double_values_20
{
    internal class Program
    {
        void dife()
        {
            Console.WriteLine("enter first number");
            int a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter first number");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                int x=(a - b) * 2;
                Console.WriteLine(x);
            }
            else
            {
                int y=b-a;
                Console.WriteLine(y);
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.dife();
            
        }
    }
}
