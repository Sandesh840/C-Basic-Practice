using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_consol.OverRiding
{
    internal  class  Phone
    {
        //virtual keyword is used to denote a class that can be override
        public virtual string ShutDown()
        {
            return "hello phone";
        }
    }
}
