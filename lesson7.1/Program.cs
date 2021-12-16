using System;

namespace lesson7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            ACoder aCoder = new ACoder();
            Console.WriteLine(aCoder.Encode("АБвя"));
            aCoder.Clear();
            Console.WriteLine(aCoder.Decode("БВга"));

            BCoder bCoder = new BCoder();
            Console.WriteLine(bCoder.Encode("АБвя"));
            bCoder.Clear();
            Console.WriteLine(bCoder.Decode("ЯЮэа"));
        }
    }
}
