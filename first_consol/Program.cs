using first_consol.Encapsulate;
using first_consol.inherite;
using first_consol.Overloading;
using first_consol.Shape;
using System;
// multiple hirearchy
/*
Redmi red=new Redmi();
Console.WriteLine(red.InstallApp("fb"));
Console.WriteLine(red.ring("note 10"));
*/

// input and printing in obj
/*
Console.WriteLine("Enter the name of car:");
string a = Console.ReadLine();
Console.WriteLine("Enter model number:");
string b = Console.ReadLine();

Bike bike=new Bike();
bike.name = a;
bike.model = b;

Console.WriteLine("The name of car is "+bike.name+" and the model number is "+bike.model);
class Bike
{
    public string name { get; set; } 
    public string model { get; set; }
}
*/

//encapsulation
/*
Bank bank=new Bank();
bank.setValue(1234);
Console.WriteLine("the atm pin is " + bank.getReturn());
*/

//method overloading
/*
Area area = new Area();
area.TSA(5,3);
Console.WriteLine(area);
Console.ReadLine();
*/

Rectangle rectangle=new Rectangle();
Circle circle=new Circle();
Console.WriteLine("type CIRCLE to calculate area of circle, and RECTANGLE to calculate area of rectangle");
string shape=Console.ReadLine();


if (shape == "CIRCLE")
{
    circle.Area();

}
else if (shape=="RECTANGLE")
{
    rectangle.Area();
}
else
{
    Console.WriteLine("please type CIRCLE or RECTANGLE");
}
Console.ReadLine();