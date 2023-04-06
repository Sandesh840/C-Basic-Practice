using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_consol.Interfacess
{
    internal class SortModel:IComparable<SortModel>
    {
        public string name { get; set; }
        public string number { get; set; }


        public SortModel(string Name, string Number)
        {
            name = Name;
            number = Number;
        }

        public int CompareTo(SortModel? test)
        {
            return name.CompareTo(test.name);
        }
    }
}
