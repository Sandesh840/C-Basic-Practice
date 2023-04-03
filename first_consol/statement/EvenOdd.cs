using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_consol.statement
{
    internal class EvenOdd
    {
        public void isEven()
        {
            //if (a == 0)
            //{
            //    Console.WriteLine("invalid digit");
            //}
            //else if (a % 2 == 0)
            //{
            //    Console.WriteLine("the number " + a + "is a even number");
            //}
            //else
            //{
            //    Console.WriteLine("the number " + a + "is a odd number");
            //}



            //for(int i = 1; i < 10; i++)
            //{
            //    if(i == 0)
            //    {
            //        Console.WriteLine("invalid number");
            //    }
            //    else if (i % 2 == 0)
            //    {
            //        Console.WriteLine("the number " + i + " is even");
            //    }
            //    else
            //    {
            //        Console.WriteLine("the number " + i + " is odd");
            //    }
            //}



            /*
            //prime or not
            for (int i = 3; i < 31; i++)
            {
                int check = 0;
                for(int a=2;a<i-1; a++)
                {
                    if (i % a == 0)
                    {
                        check = 1;
                        Console.WriteLine(i + "is a not prime number");
                        break;
                    }                               
                }
                if(check == 0)
                {
                    Console.WriteLine(i + "is a  prime number");
                }
             }
            */
            int n = 123;
            int rev = 0;
            if (n > 0)
            {
                rev=(rev*10)+(n%10);
                n = n / 10;
            }
            
            Console.WriteLine(rev);
            



        }
    }
}
