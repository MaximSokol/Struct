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
            // The additional task

            //SomeStruct str = new SomeStruct("SX-280", "SokolovFactory", 299.79);
            //str.ShowDate();

            // Tadk #1

            var obj = new Train();

            var arr = new Train[2];

            obj.FillTheArray(arr);
            obj.ShowDate(arr);

            obj.Sort(arr);
            obj.ShowDate(arr);

            obj.SearchTheTrain(arr, 1);
            obj.ShowDate(arr);




            // Task #2




        }
    }
}
