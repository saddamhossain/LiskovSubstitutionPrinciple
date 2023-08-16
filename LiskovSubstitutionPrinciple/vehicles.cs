namespace LiskovSubstitutionPrinciple;
using System;

// Another example of LSP

// We have a base class Vehicle with two virtual methods: StartEngine() and Accelerate().
// We create subclasses Car and Bicycle which inherit from Vehicle and override the StartEngine() and Accelerate() methods.
// In the Program class, we demonstrate using both a Car object and a Bicycle object through the base class Vehicle reference. The Liskov Substitution Principle holds here:
// We can interchangeably use Car and Bicycle objects in place of a Vehicle object without affecting the correctness of the program.
// While the specific behaviors may differ (e.g., how a car's engine starts vs. a bicycle's acceleration), the behavior of the program as a
// whole remains consistent when substituting derived classes for the base class.
// This example shows that the Liskov Substitution Principle ensures that derived classes can be seamlessly used as replacements for their base class,
// allowing for polymorphism and code reuse.

class Vehicle
{
    public virtual void StartEngine()
    {
        Console.WriteLine("Engine started");
    }

    public virtual void Accelerate()
    {
        Console.WriteLine("Vehicle accelerating");
    }
}

class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started");
    }

    public override void Accelerate()
    {
        Console.WriteLine("Car accelerating");
    }
}

class Bicycle : Vehicle
{
    public override void Accelerate()
    {
        Console.WriteLine("Bicycle pedaling");
    }
}