using System;

Console.WriteLine("Enter the name :");
string a = Console.ReadLine();
Console.WriteLine("Enter the model num :");
string b = Console.ReadLine();
Car car = new Car();
car.name = a;
car.model = b;
Console.WriteLine("the car is "+ car.name + " and model number is " + car.model);

class Car
{
    public string name { get; set; }
    public string model { get; set; }
}
