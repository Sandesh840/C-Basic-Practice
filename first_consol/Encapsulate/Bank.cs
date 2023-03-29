using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_consol.Encapsulate
{
    internal class Bank
    {
        private int atmPin;
        public int getReturn()
        {
            return atmPin;
        }
        public void setValue(int pin)
        {
             atmPin = pin;
        }
    }
}
