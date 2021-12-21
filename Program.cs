using System;

namespace Garage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AirPlane airplay = new AirPlane(1129, "yellow", 11, 11);
            //garage<int> Garage_test = new garage<int>(50);
            ////setting values
            //for (int c = 0; c < 5; c++)
            //{
            //    Garage_test.setItem(c, c * 5);
            //}

            //for (int c = 0; c < 5; c++)
            //{
            //    Console.Write(Garage_test.getItem(c) + " ");
            //}

            Console.WriteLine();
            var s = Garage_test.GetVehicles();
            Console.WriteLine(s);


        }
    }
}
