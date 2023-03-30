using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_consol.Abstra
{
    internal class Ivechile:Iaudi,Icar
    {
        public string description()
        {
            return "this is a boat";
        }

        public string getaudi()
        {
            return "Its a super boat";
        }

        public string name()
        {
            return "guess the name of boat";
        }
    }
    
}
