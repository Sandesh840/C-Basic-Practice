using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_consol.construct
{
    internal class PriCons
    {
        public static string name { get; set; }
        public static string number { get; set; }
        private PriCons()
        {
        }
        public static void getManager(string Mname, string Mnumber)
        {
            name=Mname;
            number=Mnumber;
            Console.WriteLine("the name is:"+ name);
            Console.WriteLine("the number is:"+ number);

        }
    }
}
