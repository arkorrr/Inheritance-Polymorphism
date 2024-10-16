using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Vehicle2
{
    public abstract void Input();
    public abstract void Output();
    public abstract double FuelConsumption();
    public abstract double GetCost();
    public abstract void SetCost(double cost);
    public abstract double LoadCapacity();
    public abstract int PassengerSeats();
}

public class Car2 : Vehicle2
{
    private double _cost;

    public override void Input()
    {
        
    }

    public override void Output()
    {
        Console.WriteLine($"Car details: Cost = {_cost}");
    }

    public override double FuelConsumption()
    {
        return 8.5; 
    }

    public override double GetCost()
    {
        return _cost;
    }

    public override void SetCost(double cost)
    {
        _cost = cost;
    }

    public override double LoadCapacity()
    {
        return 500; 
    }

    public override int PassengerSeats()
    {
        return 5; 
    }
}

public class Truck : Vehicle2
{
    private double _cost;

    public override void Input()
    {
   
    }

    public override void Output()
    {
        Console.WriteLine($"Truck details: Cost = {_cost}");
    }

    public override double FuelConsumption()
    {
        return 15; 
    }

    public override double GetCost()
    {
        return _cost;
    }

    public override void SetCost(double cost)
    {
        _cost = cost;
    }

    public override double LoadCapacity()
    {
        return 5000; 
    }

    public override int PassengerSeats()
    {
        return 3; 
    }
}