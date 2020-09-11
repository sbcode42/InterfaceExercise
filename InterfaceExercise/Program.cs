using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {


            #region InterfaceRegion

            Car myFirstCar = new Car { Year = "2011", Make = "Ford", Model = "Mustang", HasTrunk = true, CarType = "coupe" };
            Truck myFirstTruck = new Truck { Year = "2018", Make = "Chevy", Model = "Silverado", Tonneau = true, LiftKit = false };
            SUV myFirstSuv = new SUV { Year = "2000", Make = "Ford", Model = "Bronco", CargoSize = "Large", FourWheel = true };

            List<ICompany> vehicles = new List<Icompany>();


            Console.WriteLine($"{Car} is far faster than my {Truck} but the V8 in my {SUV} smokes them both.");

            #endregion


            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE -- Create 2 Interfaces called IVehicle & ICompany

            //DONE---Create 3 classes called Car , Truck , & SUV

            //DONE --- In your IVehicle

            //DONE 
            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //DONE
            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            
            //DONE
            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
