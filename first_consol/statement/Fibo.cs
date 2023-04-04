using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_consol.statement
{
    internal class Fibo
    {
        public void getfibo()
        {
            int n=15;
            int temp = n;
            int reverse = 0;
            int remainder=0;
            while (temp > 0)
            {
                remainder = temp % 10;
                temp = temp / 10;
                reverse = remainder + reverse * 10;

            }
            Console.WriteLine(reverse);


            
        }
    }
}
