using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace InterfaceExercise
{
    class Car : IVehicle,  ICompany
    {

        public bool HasTrunk { get; set; }

        public string CarType { get; set; }

        public string Logo { get; set; }

        public string Colors { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Year { get; set; }

        public int Tires { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Driving in my {GetType().Name}");
        }




    }
}
