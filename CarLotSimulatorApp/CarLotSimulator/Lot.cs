using System;
using System.ComponentModel;
using System.Linq;
using System.Collections.Generic;


namespace CarLotSimulator
{
    class Lot {

        List<Car> lot = new List<Car>();

        public void addCar(Car car) {
            lot.Add(car);
        }

        public void list() {
            for (int i = 0; i < lot.Count;  i++) {
                Console.WriteLine($"Make: {lot[i].Make}");
                Console.WriteLine($"Model: {lot[i].Model}");
                Console.WriteLine($"Year: {lot[i].Year}\n");
            }
        }
    }
}