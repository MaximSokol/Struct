using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct Train
    {
        public Train[] arr;

        string theNameOfTheDestination;
        int theNumberOfTheTrain;
        int theTimeOfLeaving;
        //----------------------------------

        public Train(string name, int number, int leaving)
        {
            this.theNameOfTheDestination = name;
            this.theNumberOfTheTrain = number;
            this.theTimeOfLeaving = leaving;

            this.arr = new Train[8];
        }
        //---------------------------------------------------

        public string NameOfDestination
        {
            get { return theNameOfTheDestination; }
        }

        public int NumberOfTrain
        {
            get { return theNumberOfTheTrain; }
        }

        public int TimeOFLeaving
        {
            get { return theTimeOfLeaving; }
        }
        //---------------------------------------------------

        public void FillTheArray(Train []arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter the name ->\t");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the number ->\t");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("The time of leaving ->\t");
                int leaving = int.Parse(Console.ReadLine());

                arr[i] = new Train(name, number, leaving);
            }
        }
        //---------------------------------------------------

        public void Sort(Train[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    if(arr[i].NumberOfTrain >= arr[j].NumberOfTrain)
                    {
                        Train obj = arr[i];
                        arr[i] = arr[j];
                        obj = arr[j];
                    }
                }
            }
        }
        //---------------------------------------------------

        public void SearchTheTrain(Train[] arr, int poisk)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i].NumberOfTrain == poisk)
                {
                    Console.WriteLine($"The number of the train:\t{arr[i].theNumberOfTheTrain}\n" +
                        $"The way of the destination:\t{arr[i].theNameOfTheDestination}\n" +
                        $"The time of leaving:\t{arr[i].theTimeOfLeaving}\n");
                }
            }
        }
        //---------------------------------------------------

        public void ShowDate(Train[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0} {1} {2}", 
                    arr[i].NumberOfTrain,
                    arr[i].NameOfDestination, 
                    arr[i].TimeOFLeaving);
            }
        }
        //---------------------------------------------------
    }
}
