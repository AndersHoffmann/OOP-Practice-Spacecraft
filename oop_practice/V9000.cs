using System;
using System.Collections.Generic;
using System.Text;

namespace oop_practice
{
    internal class V9000 : SpaceCraft //Inheritance from base class "SpaceCraft"
    {
        //Additional properties specific for the derived class
        public bool AutoPilot { get; set; }
        public SpaceCraftColor Color { get; set; }

        //Constructor for derived class - implements the constructor behaviour from base class, and adds additional properties to constructor. 
        private V9000(string model, string fuelType, string launchDate, SpaceCraftColor color, bool autoPilot) : base(model, fuelType, launchDate)
        {
            this.Color = color;
            this.AutoPilot = autoPilot;
        }
        //Factory Method for V9000
        internal static V9000 CreateInstance(string model, string fuelType, string launchDate, SpaceCraftColor color, bool autoPilot)
        {
            return new V9000(model, fuelType, launchDate, color, autoPilot);
        }
        //Example for adding implementation to abstract method
        internal override void StartEngine()
        {
            Console.WriteLine("V9000 Engine Is Started!");
        }
        //Example for adding implementation to virtual method - same as abstract! 
        internal override void RefillFuel()
        {
            Console.WriteLine("V9000 Fuel is refilled!");
        }

        //Override to ToString method.
        public override string ToString()
        {
            return $"Model: {base.Model}, FuelType: {base.FuelType}, LaunchDate: {base.LaunchDate}, Color: {this.Color}, AutoPilot: {this.AutoPilot}";
        }
    }
}
