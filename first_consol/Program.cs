using first_consol.Abstra;
using first_consol.Encapsulate;
using first_consol.inherite;
using first_consol.Overloading;
using first_consol.OverRiding;
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
Area area = new Area();
//method overloading
/*
area.TSA(5,3);
Console.WriteLine(area);
Console.ReadLine();
*/

/*
Console.WriteLine("ENter two integer");
int x=Convert.ToInt32(Console.ReadLine());
int y=Convert.ToInt32(Console.ReadLine());
int z = area.Math(x, y);
Console.WriteLine("The sum is :" + z);

Console.WriteLine("ENter two double");
double l = Convert.ToDouble(Console.ReadLine());
double m = Convert.ToDouble(Console.ReadLine());
double n = area.Math(l, m);
Console.WriteLine("The diference is :" + n);
*/

// Area of rectangle and circle according to input by users
/*
Rectangle rectangle=new Rectangle();
Circle circle=new Circle();
Console.WriteLine("Type CIRCLE to calculate area of circle, and RECTANGLE to calculate area of rectangle");
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
*/
/*
Phone phone=new Phone();
Android android=new Android();
ApplePhone applePhone=new ApplePhone();

Console.WriteLine(phone.ShutDown());
Console.WriteLine(applePhone.ShutDown());
Console.WriteLine(android.ShutDown());
*/
/*
Boat ford = new Ship();
Console.WriteLine(ford.BoatMove());
Console.WriteLine(ford.BoatType());
*/
Ivechile vechile =new Ivechile();
Console.WriteLine(vechile.description());
Console.WriteLine(vechile.name());
string a= Console.ReadLine();
