using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * DONE - Todo follow all comments!! 
             */

            #region Vehicles

            /*
             DONE - * Create an abstract class called Vehicle
             DONE - * The vehicle class shall have three string properties Year, Make, and Model
             DONE - * Set the defaults to something generic in the Vehicle class
             DONE - * Vehicle shall have an abstract method called DriveAbstract with no implementation
             DONE - * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             DONE - * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             DONE - * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             DONE - * Provide the implementations for the abstract methods
             DONE - * Only in the Motorcycle class will you override the virtual drive method
            */

            // DONE - Create a list of Vehicle called vehicles - done in Vehicle class

           
            /*
             DONE - * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use 
             DONE - * constuctors from derived classes - new it up as one of each derived class
             DONE - * Set the properties with object initializer syntax
             */

            Car car1 = new Car()
            {
                Year = 2022,
                Make = "Aston Martin",
                Model = "Vanquish",
                HasTrunk = true
            };
            Vehicle.Vehicles.Add(car1);

            Motorcycle motorcycle1 = new Motorcycle()
            {
                Year = 2022,
                Make = "Harley-Davidson",
                Model = "Fat Boy",
                HasSideCart = false
            };
            Vehicle.Vehicles.Add(motorcycle1);

            Vehicle car2 = new Car()
            {
                Year = 1933,
                Make = "Ford",
                Model = "Model T",
                HasTrunk = false
            };
            Vehicle.Vehicles.Add(car2);

            Vehicle motorcycle2 = new Motorcycle()
            {
                Year = 1955,
                Make = "Honda",
                Model = "Cafe Racer",
                HasSideCart = true
            };
            Vehicle.Vehicles.Add(motorcycle2);


            /*
             DONE - * Add the 4 vehicles to the list
             DONE - * Using a foreach loop iterate over each of the properties
             */

            foreach (var vehicle in Vehicle.Vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}");
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine();
            }

            // DONE - Call each of the drive methods for one car and one motorcycle

            Console.WriteLine("Drive methods for car1: ");
            car1.DriveAbstract();
            car1.DriveVirtual();
            Console.WriteLine();

            Console.WriteLine("Drive methods for motorcycle1: ");
            motorcycle1.DriveAbstract();
            motorcycle1.DriveVirtual();

            #endregion            
            Console.ReadLine();
        }
    }
}
