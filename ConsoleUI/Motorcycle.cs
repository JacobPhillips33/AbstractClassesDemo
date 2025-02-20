﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"This motorcycle is cruising!");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"This motorcycle is flying!");
        }
    }
}
