using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_consol.statement
{
    internal class Prime
    {
        public void prime()
        {
            
            for(int i = 2; i < 31; i++)
            {
                int flag=0;
                for(int j = 2; j < i-1; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 1;
                        Console.WriteLine(i+"  is a not a prime number");
                        break;
                    }
                }
                if(flag == 0)
                {
                    Console.WriteLine(i+" is a prime number");
                    
                }
            }
        }
    }
}
