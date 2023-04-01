using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_consol.construct
{
    internal class Construct
    {
        int num = 0;
        int a;
        public Construct()
        {
            num = 5;
        }
        public void Show()
        {
            Console.WriteLine(num);
        }
        public Construct(int ab)
        {
            a= ab;
        }
        public void Showpara()
        {
            Console.WriteLine(a);
           
        }
    }
}
