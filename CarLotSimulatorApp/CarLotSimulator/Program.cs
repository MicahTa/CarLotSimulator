﻿using System;
using System.Data.Common;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Lot garage = new Lot();
            Car ranger = new Car() {make = "Ford", model = "Ranger", year = 2004, engineNoise = "VROOM VROOM", honkNoise = "HONKA HONKA", isDriveable = true};
            garage.AddCar(ranger);
            Console.WriteLine($"There are {Lot.numberOfCars} cars");
            Car clownCar = new Car("VoltesWaggon", "Bug", 2008, "vrrrrrr", "BEEP BEEP", true);
            garage.AddCar(clownCar);
            Console.WriteLine($"There are {Lot.numberOfCars} cars");
            Car brothersCar = new Car();
            garage.AddCar(brothersCar);
            Console.WriteLine($"There are {Lot.numberOfCars} cars");

            
            brothersCar.Make = "Jeep";
            brothersCar.Model = "Cherokee";
            brothersCar.Year = 2000;
            brothersCar.EngineNoise = "Click Clank";
            brothersCar.HonkNoise = "HOOoooonnk";
            brothersCar.IsDriveable = false;


            ranger.MakeEngineNoise();
            ranger.MakeHonkNoise();

            clownCar.MakeEngineNoise();
            clownCar.MakeHonkNoise();

            brothersCar.MakeEngineNoise();
            brothersCar.MakeHonkNoise();
            Console.Write("\n");

            garage.List();
        }
    }
}
