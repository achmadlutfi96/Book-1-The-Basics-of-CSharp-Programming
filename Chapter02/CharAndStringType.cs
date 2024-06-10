using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
{
    internal class CharAndStringType
    {
        public static void Print()
        {
            char a = 'a';

            string b = "aku adalah superman\nbenarkah demikian?\tiya";
            string c = "\0";
            string d = string.Empty;
            string e = "\\";

            string f = "rodri";
            string g = $"halo {f}";

            string h = @"C:\document\files\\"; // special character diabaikan
        }
    }
}
