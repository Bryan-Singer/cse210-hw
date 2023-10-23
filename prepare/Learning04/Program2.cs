using System;

class Program2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
    }
}

public class Vehicle {

    private string _make;
    private string _model;
    private int _miles;

    public Vehicle(string make, string model, int miles) {
        _make = model;
        _model = model;
        _miles = miles;
    }
}

public class Car: Vehicle {

    public Car(string make, string model, int miles) : base(make, model, miles) {
    
    }

}

public class Truck: Vehicle {
    private int _towing;

    public Truck(string make, string model, int miles, int towing) : base(make, model, miles) {
        _towing = towing;
    }
}