using System;

namespace lesson3._2
{
    class Program
    {
        static string Rev(string str)
        {
            char[] reverse = str.ToCharArray();
            Array.Reverse(reverse);
            return new string(reverse);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            str = Rev(str);
            Console.WriteLine(str);
        }
    }
}
