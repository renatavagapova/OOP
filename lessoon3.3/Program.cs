using System;
using System.Collections.Generic;

namespace lessoon3._3
{
    class Program
    {
        static List<string> data = new List<string>();
        static List<string> dataNew = new List<string>();
        static void Main(string[] args)
        {
            string _data1 = new string("Кучма Андрей Витальевич & Kuchma@mail.ru");
            string _data2 = new string("Мизинцев Павел Николаевич & Pasha@mail.ru");
            string s = _data1;

            data.Add(_data1);
            data.Add(_data2);
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
            dataNew = data;
            Console.WriteLine();
            foreach (var item in dataNew)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            SearchMailFull(ref dataNew);
            Console.WriteLine();
            Console.WriteLine(s);
            SearchMail(ref s);
        }

        public static void SearchMail(ref string s)
        {
            string[] words = s.Split(new char[] { '&' });
            s = words[1].Remove(0, 1);
            Console.WriteLine(s);
        }

        public static void SearchMailFull(ref List<string> dataNew)
        {
            foreach (var item in dataNew)
            {
                string text = item;
                string[] words = text.Split(new char[] { '&' });
                text = words[1].Remove(0, 1);
                Console.WriteLine(text);
            }
        }

    }
}

