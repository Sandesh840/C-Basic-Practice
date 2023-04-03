using first_consol.Abstra;
using first_consol.construct;
using first_consol.Encapsulate;
using first_consol.inherite;
using first_consol.Overloading;
using first_consol.OverRiding;
using first_consol.Shape;
using first_consol.statement;
using System;
using System.Runtime.InteropServices;
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

        //Area area = new Area();
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

        /*
        Ivechile vechile =new Ivechile();
        Console.WriteLine(vechile.description());
        Console.WriteLine(vechile.name());
        */


        //constructor
        /*
        int x = 7;
        Construct con = new Construct();
        Construct con1 = new Construct(x);
        con.Show();
        con1.Showpara();
        con.ShowStatic();
        */

        /*
        //calling paramater cons with employee detail
        string a = "hari";
        int b = 20;
        Employee emp = new Employee(a,b);
        Employee copy = new Employee(emp);
        */


        /*
        // CallingConvention private constructor
        PriCons.getManager("boi", "258");
        */
        // int i = 5; i <= 5; i++

        //int a = 1;
        //Console.WriteLine("this is a while loop");
        //while (a<=5)
        //{
        //    Console.WriteLine("the num is "+a);
        //    a += 1;
        //}
        //Console.WriteLine("this is a do while loop");
        //int b = 1;
        //do
        //{
        //    Console.WriteLine("the number is :" + b);
        //    b += 1;
        //}
        //while(b<=5);

        //Console.WriteLine("this is a for loop");
        //for(int i = 1; i < 5; i++)
        //{
        //    Console.WriteLine("the number is :" +i);
        //}

        //Console.WriteLine("this is for each loop");
        ////creating lists

        //List<int>Numbers = new List<int>();
        //Numbers.Add(1); 
        //Numbers.Add(2);
        //Numbers.Add(3);
        //Numbers.Add(4);
        //Numbers.Add(5);

        //foreach(int item in Numbers)
        //{
        //    Console.WriteLine("the number is: "+ item);
        //}

        //for (int i = 1; i < 4; i++)
        //{
        //    Console.WriteLine("GeeksforGeeks");
        //    break;
        //}

        //for(int i = 1; i <= 10; i++)
        //{
        //    if (i == 4)
        //        continue;
        //    Console.WriteLine(i);
        //}

        EvenOdd evenOdd = new EvenOdd();
        //Console.WriteLine("enter a number");
        //evenOdd.isEven(Convert.ToInt32(Console.ReadLine()));
        evenOdd.isEven();

        Console.ReadLine();

        //swich statement
        /*
        Console.WriteLine("enter the number of week");
        string a =Console.ReadLine();
        int b =Convert.ToInt32(a);
        if (b < 0)
        {
            Console.WriteLine("the number cannot be negative");
        }
        else if (b > 7)
        {
            Console.WriteLine("the number should not be less than 7");
        }
        else
        {
            switch (a)
            {
                case "1":
                    Console.WriteLine("its sunday");
                    break;
                case "2":
                    Console.WriteLine("its monday");
                    break;
                case "3":
                    Console.WriteLine("its tuesday");
                    break;
                case "4":
                    Console.WriteLine("its wednusday");
                    break;
                case "5":
                    Console.WriteLine("its thrusday");
                    break;
                case "6":
                    Console.WriteLine("its friday");
                    break;
                case "7":
                    Console.WriteLine("its saturday");
                    break;
                default:
                    Console.WriteLine(a + "should be between 1 and 7");
                    break;
            }
        }
        
        

        */
        Console.ReadLine();
    
