using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_consol.Builder
{
    internal class Builder
    {
        public void SetBuilder()
        {
            string str = string.Empty;
            for(int i = 0; i < 10; i++)
            {
                str += "Modify";
                Console.WriteLine(str);
            }

            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < 10; i++)
            {
                sb.Append("Modify");
                Console.WriteLine(sb);
            }
        }
    }
}
