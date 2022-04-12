using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeStruct str = new SomeStruct("SX-280", "SokolovFactory", 299.79);
            str.ShowDate();

        }
    }
}
