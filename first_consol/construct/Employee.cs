using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_consol.construct
{
    internal class Employee
    {
        public string name { get; set; }    
        public int number { get; set; }
        //parameter constructor
        public Employee(string empName, int phNum)
        {
            name = empName;
            number = phNum;
        }
        public Employee(Employee ram)
        {
            Console.WriteLine("Employee name is :"+ram.name);
            Console.WriteLine("Employee number is :"+ram.number);
        }

    }
}
