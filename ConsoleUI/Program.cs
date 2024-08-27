using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{

    // Create a list of Vehicle called vehicles

    /*
     * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
     *
     * Set the properties values with object initializer syntax
     */

    /*
     * Add the 4 vehicles to the list
     * Using a foreach loop iterate through the list and display each of the properties
     */

    // Call each of the drive methods for one car and one motorcycle
    class Program
    {
        static void Main(string[] args)
        {
           


            //car #1
            Car firstCar = new Car();
            firstCar.Make = "Lexus";
            firstCar.Model = "RX350";
            firstCar.Year = 2020;
            firstCar.HasTrunk = true;

            firstCar.DriveAbstract();
            firstCar.DriveVirtual();
            
            
            //car #2
            var secondCar = new Car()
            {
                Make = "Nissan",
                Model = "Rogue",
                Year = 2021,
                HasTrunk = false

            };
            
            secondCar.DriveAbstract();
            secondCar.DriveVirtual();
            
            
            //motorcycle #1
            Motorcycle firstMotorcycle = new Motorcycle();
            firstMotorcycle.Make = "Honda";
            firstMotorcycle.Model = "CBR600RR";
            firstMotorcycle.Year = 2020;
            
            firstMotorcycle.DriveAbstract();
            firstMotorcycle.DriveVirtual();
            
            
            //motorcycle #2
            var secondMotorcycle = new Motorcycle()
            {
                Make = "Suzuki",
                Model = "GSX-R1000",
                Year = 2022

            };
            
            secondMotorcycle.DriveAbstract();
            secondMotorcycle.DriveVirtual();
           
            
            
            
        }






    }
}