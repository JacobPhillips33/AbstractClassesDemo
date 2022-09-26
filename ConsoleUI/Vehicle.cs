using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {        
        public int Year { get; set; } = 0;
        public string Make { get; set; } = "make";
        public string Model { get; set; } = "model";

        public static List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This vehicle is driving.");
        }
    }
}
