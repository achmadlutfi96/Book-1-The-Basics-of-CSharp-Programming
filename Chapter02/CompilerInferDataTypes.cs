using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
{
    internal class CompilerInferDataTypes
    {
        public CompilerInferDataTypes() {

            var a = 5 + 6.0 * 7;

            var aString = "Hello C# 3.0";
            Console.WriteLine(aString.GetType().ToString());
        }
    }
}
