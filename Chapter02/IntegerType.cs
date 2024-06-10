using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
{
    internal class IntegerType
    {
        public static void Print()
        {
            sbyte a = 127; // range -128 to 127

            byte b = 225; // range 0 to 225

            short c = -32000; // range -32,768 to 32,767

            ushort d = 65000; // range 0 to 65,535

            int e = 1213542323; // range –2,147,483,648 to 2,147,483,647 

            uint f = 3253623253; // range 0 to 4,294,967,295

            long g = 2_911_726_172_617L; // range –9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

            ulong h = 7_382_637_262_387L; // range 0 to 18,446,744,073,709,551,615

            nint i = 6; // Native Integer
            nint j = 9; // Native integer

            int k = 0b1010101011; // binary
            int l = 0x7_677_fff;  // Hexadecimal
        }
    }
}
