using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class MyClass
    {
        public string change;

        public string Change { get { return change; } }

        public static void ClassTaker(MyClass myClas)
        {
           myClas.change = "changed!";
        }
    }
}
