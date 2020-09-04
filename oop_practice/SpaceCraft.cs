using System;
using System.Collections.Generic;
using System.Text;

namespace oop_practice
{
    //Example Enum in Base class, usable in derived classes if desired. 
    internal enum SpaceCraftColor
    {
        Blue,
        Yellow,
        Green,
        White
    }

    internal abstract class SpaceCraft
    {
        //Base class properties example
        public string Model { get; set; }
        public string FuelType { get; set; }
        public string LaunchDate { get; set; }

        //Base class constructor example.
        protected SpaceCraft( string model, string fuelType, string launchDate)
        {
            this.Model = model;
            this.FuelType = fuelType;
            this.LaunchDate = launchDate;
        }

        //Abstract method example - cannot have default implementation!
        internal abstract void StartEngine();

        //Virtual method example - requires default implementation! (Can be empty though..) 
        internal virtual void RefillFuel()
        {
            Console.WriteLine("Fuel is refilled!");
        }

    }
}
