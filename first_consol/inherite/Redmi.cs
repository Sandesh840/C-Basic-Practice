using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_consol.inherite
{
    internal class Redmi : ICellphone, iAndroid
    {
        public string InstallApp(string appName)
        {
            return "app installed Success: " + appName;
        }

        public string ring(string phonemodel)
        {
            return "phone ring: "+ phonemodel;
        }
    }
}
