using System;
using System.Collections.Generic;

namespace ClassExercise
{
    class Program {

        static void Main(string[] args)
        {
            Car firstVehicle = new Car();
            firstVehicle.Make = "Ford";
            firstVehicle.Model = "Fusion";
            firstVehicle.Year = 2012;
            Console.WriteLine(firstVehicle.Make);
            Console.WriteLine(firstVehicle.Model);
            Console.WriteLine(firstVehicle.Year);
        }


        public class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
        }
    }
}
