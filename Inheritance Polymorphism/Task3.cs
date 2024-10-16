using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Vehicle
{
    public string Model { get; set; }

    public Vehicle(string model)
    {
        Model = model;
    }

    public abstract void Display();
}

public class Plane : Vehicle
{
    public Plane(string model) : base(model) { }

    public override void Display()
    {
        Console.WriteLine($"Plane Model: {Model}");
    }
}

public class Car : Vehicle
{
    public Car(string model) : base(model) { }

    public override void Display()
    {
        Console.WriteLine($"Car Model: {Model}");
    }
}