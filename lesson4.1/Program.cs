using System;

namespace lesson4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building();
            building.Add(3, 4, 5);

            Building building2 = new Building();
            building2.Add(4, 8, 7, 5);

            building.Print();
            building2.Print();
            building.Print();
        }
    }
}
