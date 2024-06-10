using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
{
    internal class Casting
    {
        public Casting() 
        {   
            int intValue = 10;
            long longValue;
            longValue = intValue;

            long longValue2 = 10;
            int intValue2;
            intValue2 = (int)longValue2;

        }
    }
}
