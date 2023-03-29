using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_consol.Shape
{
    internal class Rectangle
    {
        public void Area()
        {
            Console.WriteLine("enter the length");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the breath");
            double breath = Convert.ToDouble(Console.ReadLine());
            double area=length*breath;
            Console.WriteLine("the area of rectangle is "+ area);
        }
    }
}
