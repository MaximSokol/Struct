using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct MyStruct
    {
        public string change;

        public string Change { get { return change; } }

        public static void StructTaker(MyStruct stuct)
        {
            stuct.change = "changed";
        }
    }
}
