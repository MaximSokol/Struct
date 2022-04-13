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

            //var obj = new Train();

            //var arr = new Train[2];

            //obj.FillTheArray(arr);
            //obj.ShowDate(arr);

            //obj.Sort(arr);
            //obj.ShowDate(arr);

            //obj.SearchTheTrain(arr, 1);
            //obj.ShowDate(arr);


            // Task #2

            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();

            myClass.change = "not changed";
            myStruct.change = "not changed";

            MyClass.ClassTaker(myClass);
            MyStruct.StructTaker(myStruct);

            Console.WriteLine($"MyClass:\t{myClass.Change}");
            Console.WriteLine($"MyStruct:\t{myStruct.Change}");

            MyStruct structSome;
            structSome.change = "dghdjfgdf";

        }
    }
}
