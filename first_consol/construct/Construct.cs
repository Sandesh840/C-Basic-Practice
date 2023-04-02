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
        public static string name;
        public static int age;

        //default constructor
        public Construct()
        {
            num = 5;
        }
        public void Show()
        {
            Console.WriteLine(num);
        }
        //parameterized construct
        public Construct(int ab)
        {
            a= ab;
        }
        public void Showpara()
        {
            Console.WriteLine(a);
           
        }
        //static constructor
        static Construct()
        {
            name = "sandesh";
            age = 21;
            // Console.WriteLine(name+age);
        }
        public void ShowStatic()
        {
            Console.WriteLine(name + age);
        }
        
    }
}
