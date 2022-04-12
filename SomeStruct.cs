using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct SomeStruct
    {
        string model;
        string manufacturer;
        double price;
        //-------------------
        
        public SomeStruct(string model, string manufacturer, double price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }
        //----------------------------------------------------------------------

        public void ShowDate()
        {
            Console.WriteLine($"Model:\t{this.model}\n" +
                $"Manufacturer:\t{this.manufacturer}\n" +
                $"Price:\t{this.price}\n");
        }
        //---------------------------
    }
}
