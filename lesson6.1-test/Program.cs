using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson6._1_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            Console.WriteLine("Speed: {0}mph", v.Speed);    // "Speed 0mph"
            v.Accelerate(25);
            Console.WriteLine("Speed: {0}mph", v.Speed);    // "Speed 25mph"
            v.Decelerate(15);
            Console.WriteLine("Speed: {0}mph", v.Speed);    // "Speed 10mph"

            MotorVehicle mv = new MotorVehicle();
            Console.WriteLine("Speed: {0}mph", mv.Speed);    // "Speed 0mph"
            mv.Accelerate(25);
            Console.WriteLine("Speed: {0}mph", mv.Speed);    // "Speed 25mph"
            mv.Decelerate(15);
            Console.WriteLine("Speed: {0}mph", mv.Speed);    // "Speed 10mph"

            MotorVehicle car = new MotorVehicle();
            car.TankSize = 11;
            Console.WriteLine("Fuel: {0}g", car.FuelRemaining); // "0g"
            car.Refuel();
            Console.WriteLine("Fuel: {0}g", car.FuelRemaining); // "11g"

            Bicycle bike = new Bicycle();
            bike.RingBell();                                     // "Ring!"

            var dict = new Dictionary<string, int>();
            dict["first"] = 10;
            dict["second"] = 20;
            dict["third"] = 30;

            Console.WriteLine(string.Join("; ", dict.Select(entry => $"{entry.Key}: {entry.Value}")));
            // Output:
            // first: 10; second: 20; third: 30

            var dict2 = new Dictionary<string, int>
            {
                ["first"] = 10,
                ["second"] = 20,
                ["third"] = 30
            };

            Console.WriteLine(string.Join("; ", dict2.Select(entry => $"{entry.Key}: {entry.Value}")));
            // Output:
            // first: 10; second: 20; third: 30

            List<int> xs = new List<int>();
            List<int> ys = new List<int>(capacity: 10_000);
            List<int> zs = new List<int>() { Capacity = 20_000 };

            Dictionary<int, List<int>> lookup = new Dictionary<int, List<int>>()
            {
                [1] = new List<int>() { 1, 2, 3 },
                [2] = new List<int>() { 5, 8, 3 },
                [5] = new List<int>() { 1, 0, 4 }
            };

            var numbers = new int[3];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;

            Console.WriteLine(string.Join(", ", numbers));
            // Output:
            // 10, 20, 30

            var a = new int[3] { 10, 20, 30 };
            var b = new int[] { 10, 20, 30 };
            var c = new[] { 10, 20, 30 };
            Console.WriteLine(c.GetType());  // output: System.Int32[]

            var example = new { Greeting = "Hello", Name = "World" };
            Console.WriteLine($"{example.Greeting}, {example.Name}!");
            // Output:
            // Hello, World!

            MySubclass test = new MySubclass();

            MySubclass test10 = new MySubclass(10);

            MotorVehicle car2 = new MotorVehicle();
            car2.Indicate(true);                     // "Flashing left indicator"

            Bicycle bike2 = new Bicycle();
            bike2.Indicate(true);                    // "Raising left arm"

        }

        class MyBaseClass
        {
            public MyBaseClass()
            {
                Console.WriteLine("MyBaseClass constructor called.");
            }

            public MyBaseClass(int aNumber)
            {
                string output;
                output = string.Format("MyBaseClass created with value {0}.", aNumber);
                Console.WriteLine(output);
            }

            ~MyBaseClass()
            {
                Console.WriteLine("MyBaseClass destructor called.");
            }
        }


        class MySubclass : MyBaseClass
        {
            public MySubclass()
            {
                Console.WriteLine("MySubclass constructor called.");
            }

            public MySubclass(int startValue) : base(startValue)
            {
                string output;
                output = string.Format("MySubclass created with value {0}.", startValue);
                Console.WriteLine(output);
            }



            ~MySubclass()
            {
                Console.WriteLine("MySubclass destructor called.");
            }
        }
    }
}
