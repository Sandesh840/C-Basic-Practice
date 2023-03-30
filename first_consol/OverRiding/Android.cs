using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_consol.OverRiding
{
    internal class Android:Phone
    {
        //override keyword is used to override the virtual method
        public override string ShutDown()
        {
            return " android shutdown ";
        }
    }
}
