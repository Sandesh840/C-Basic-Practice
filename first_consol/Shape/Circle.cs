using first_consol.Overloading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_consol.Shape
{
    internal class Circle
    {
        public  void Area()
        {
            double pi = 3.1415;
            Console.WriteLine("Enter the radius of circle");
            double radius = Convert.ToDouble( Console.ReadLine());
            double area=pi*radius*radius;
            Console.WriteLine("the area of circle is :" + area);
            
        }

    }
}
