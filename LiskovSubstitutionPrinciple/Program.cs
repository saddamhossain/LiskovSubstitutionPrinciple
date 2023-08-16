using LiskovSubstitutionPrinciple;

/*
  Liskov Substitution Principle (LSP).
 This is what LSP means:
 -> A child/sub/derived class should be substitutable for its base class without causing unexpected behavior. This principle is very similar to the Interface Segregation Principle.
*/

Vehicle car = new Car();
Vehicle bicycle = new Bicycle();

car.StartEngine();
car.Accelerate();

Console.WriteLine();

bicycle.StartEngine();
bicycle.Accelerate();

Console.WriteLine("Hello there! The Liskov Substitution Principle is here! Please check the codebase.");
Console.ReadKey();