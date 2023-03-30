using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace first_consol.Abstra
{
    internal abstract class Boat
    {
        public string BoatMove()
        {
            return "boat";
        }
        public abstract string BoatType();
    }
}
