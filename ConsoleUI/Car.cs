using System;

namespace ConsoleUI;

/*
 * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
 * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
 * Provide the implementations for the abstract methods
 * Only in the Motorcycle class will you override the virtual drive method
 */






public class Car: Vehicle
{
    public bool HasTrunk { get; set; }


    public override void DriveAbstract()
    {
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("Drive the car!");
        Console.WriteLine($"It is {HasTrunk} that the car has a trunk");
    }
}