using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : IVehicle, ICompany
    {
        public string CargoSize { get; set; }

        public bool FourWheel { get; set; }
       
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
