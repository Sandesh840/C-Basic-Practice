using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_consol.OverRiding
{
    internal class ApplePhone:Phone
    {
        public override string ShutDown()
        {
            return " shutddown apple ";
        }
    }
}
