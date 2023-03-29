using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_consol.Overloading
{
    internal class Area
    {
        public void TSA(int l,int b)
        {
            Console.WriteLine(l*b);
        }
        public void TSA(float r, double pie=3.1415)
        {
            Console.WriteLine(pie * r * r);
        }
    }
}
