using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_consol.statement
{
    internal class Palandrom
    {
        public void pal()
        {
            Console.WriteLine("kati oota number ko fibo series chayo?");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Are You sure");
            string y = Console.ReadLine();
            Console.WriteLine("Feri sochau?");
            string z = Console.ReadLine();
            Console.WriteLine("LOCK KIYA JAYA?");
            string w = Console.ReadLine();

            
            int a = 0;
            int b = 1;
            int c=0;
            Console.WriteLine("0");
            Console.WriteLine("1");
            for(int i = 2; i <=n ; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
        }
    }
}
