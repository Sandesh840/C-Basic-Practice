using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_consol.statement
{
    internal class Swich
    {
        public void isSwich()
        {
            Console.WriteLine("enter the number of week");
            string a = Console.ReadLine();
            int b = Convert.ToInt32(a);
            if (b < 0)
            {
                Console.WriteLine("the number cannot be negative");
            }
            else if (b > 7)
            {
                Console.WriteLine("the number should not be less than 7");
            }
            else
            {
                switch (a)
                {
                    case "1":
                        Console.WriteLine("its sunday");
                        break;
                    case "2":
                        Console.WriteLine("its monday");
                        break;
                    case "3":
                        Console.WriteLine("its tuesday");
                        break;
                    case "4":
                        Console.WriteLine("its wednusday");
                        break;
                    case "5":
                        Console.WriteLine("its thrusday");
                        break;
                    case "6":
                        Console.WriteLine("its friday");
                        break;
                    case "7":
                        Console.WriteLine("its saturday");
                        break;
                    default:
                        Console.WriteLine(a + "should be between 1 and 7");
                        break;
                }
            }


            //Console.WriteLine("ehter the number to find off or even");
            //int a=Convert.ToInt32(Console.ReadLine());

            //for(int i = 1; i <= a; i++)
            //{

            //    switch (i%2)
            //    {

            //        case 0: Console.WriteLine(i + "even");
            //        break;
            //        default: Console.WriteLine(i + "odd");
            //            break ;
            //    }
            //}    
        }
    }
}
