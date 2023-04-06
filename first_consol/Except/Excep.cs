using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_consol.Except
{
    
    internal class Excep
    {
        class Test1
        {
            public string Name { get; set; }
        }
        public void getExcep()
        {
            string exceptionmsh = null;
            Console.WriteLine("enter first number");
            int a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            try { 
            
                Test1 test1 = null;
                test1.Name = "ram";
                int c = a / b;
                Console.WriteLine(a+ "divide by "+b+"is "+c);

            }
            catch(DivideByZeroException e)
            {
                exceptionmsh = e.Message;
                Console.WriteLine("invalid input data, may be try not to put 0 in divider");
            }
            catch(NullReferenceException ex)
            {
                exceptionmsh=ex.Message;
                Console.WriteLine("null refrence error has been occured");

            }
            finally
            {
                if(exceptionmsh == null)
                {
                    Console.WriteLine("no exc ocured");
                }
                else
                {
                    Console.WriteLine("excep occured");
                }
            }
        }
    }
}
