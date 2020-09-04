using System;
using System.Collections.Generic;
using System.Text;

namespace oop_practice
{

    //Second Derived class - explanation in "V9000" 

    internal class X5000 : SpaceCraft
    {
        public static X5000 CreateInstance(string model, string fuelType, string launchDate, SpaceCraftColor color, bool autoPilot, string projectManager)
        {
            return new X5000(model, fuelType, launchDate, color, autoPilot, projectManager);
        }

        public SpaceCraftColor Color { get; set; }
        public bool AutoPilot { get; set; }
        public string ProjectManager { get; set; }


        private X5000(string model, string fuelType, string launchDate, SpaceCraftColor color, bool autoPilot, string projectManager) : base(model, fuelType, launchDate)
        {
            this.Color = color;
            this.AutoPilot = autoPilot;
            this.ProjectManager = projectManager;
        }


        internal override void StartEngine()
        {
            Console.WriteLine("X5000 Engine Is Started!");
        }

        internal override void RefillFuel()
        {
            Console.WriteLine("X5000 Fuel is refilled!");
        }

        public override string ToString()
        {
            return $"Model: {base.Model}, FuelType: {base.FuelType}, LaunchDate: {base.LaunchDate}, Color: {this.Color}, AutoPilot: {this.AutoPilot}, ProjectManager: {this.ProjectManager}";
        }
    }
}
