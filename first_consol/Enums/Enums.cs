using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_consol.Enums
{
    internal class Enums
    {
        public void Check()
        {
            Console.WriteLine("enter number of days");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your bday is" + (WeekDay)a);
        }

            enum WeekDay
            {
            sunday=1,
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday
            }       
    }
}
