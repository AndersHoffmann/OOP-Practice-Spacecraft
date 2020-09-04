using System;
using System.Runtime.CompilerServices;
using static System.Console;

namespace oop_practice
{
    internal class Program
    {
        private static void Main(string[] args)
        { 
            //Instances of classes
           SpaceCraft vSpaceCraft = V9000.CreateInstance(model: "V9000-B", fuelType: "LXO", launchDate: "4/11", color: SpaceCraftColor.Blue, autoPilot: true); 
           SpaceCraft xSpaceCraft = X5000.CreateInstance(model: "X-5000-L", fuelType: "LXO", launchDate: "6/12", color: SpaceCraftColor.Green, autoPilot: false, projectManager:"John");

           //Example of polymorphism - same method from base class overwritten differently in derived classes. 
           WriteLine("***V9000 SpaceCraft***");
           WriteLine(vSpaceCraft);
           vSpaceCraft.RefillFuel();
           vSpaceCraft.StartEngine();
           
                
           WriteLine("***X5000 SpaceCraft***");
           WriteLine(xSpaceCraft);
           xSpaceCraft.RefillFuel();
           xSpaceCraft.StartEngine();
           
        }


    }
}
