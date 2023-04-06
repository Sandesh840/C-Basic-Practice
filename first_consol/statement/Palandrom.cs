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
            //console.writeline("are you sure");
            //string y = console.readline();
            //console.writeline("feri sochau?");
            //string z = console.readline();
            //console.writeline("lock kiya jaya?");
            //string w = console.readline();
            int a = 0;
            int b = 1;
            int c=0;
            Console.Write("0 ");
            Console.Write(" 1 ");
            for(int i = 2; i <=n ; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.Write(" "+c);
            }
        }
    }
}
