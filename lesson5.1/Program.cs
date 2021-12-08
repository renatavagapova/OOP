using System;

namespace lesson5._1
{
    public class RationalNumbers
    {
        /// <summary>
        /// числитель
        /// </summary>
        private int _numerator;

        /// <summary>
        /// знаменатель
        /// </summary>
        private uint _denominator;

        private const string ZERO = "0";

        public RationalNumbers(int numeretor, uint denominator)
        {
            _numerator = numeretor;
            _denominator = denominator;
        }

        public static bool operator ==(RationalNumbers r1, RationalNumbers r2)
        {
            return (r1._numerator == r2._numerator && r1._denominator == r2._denominator);
        }

        public static bool operator !=(RationalNumbers r1, RationalNumbers r2)
        {
            return (r1._numerator != r2._numerator && r1._denominator != r2._denominator);
        }

        public static bool operator >(RationalNumbers r1, RationalNumbers r2)
        {
            double num1 = (double)r1._numerator / (double)r1._denominator;
            double num2 = (double)r2._numerator / (double)r2._denominator;

            return (num1 > num2);
        }

        public static bool operator <(RationalNumbers r1, RationalNumbers r2)
        {
            double num1 = (double)r1._numerator / (double)r1._denominator;
            double num2 = (double)r2._numerator / (double)r2._denominator;

            return (num1 < num2);
        }

        public static bool operator >=(RationalNumbers r1, RationalNumbers r2)
        {
            double num1 = (double)r1._numerator / (double)r1._denominator;
            double num2 = (double)r2._numerator / (double)r2._denominator;

            return (num1 >= num2);
        }

        public static bool operator <=(RationalNumbers r1, RationalNumbers r2)
        {
            double num1 = (double)r1._numerator / (double)r1._denominator;
            double num2 = (double)r2._numerator / (double)r2._denominator;

            return (num1 <= num2);
        }

        public static RationalNumbers operator +(RationalNumbers r1, RationalNumbers r2)
        {
            uint newDenominator = r1._denominator * r2._denominator;
            int newNumerator = r1._numerator * (int)r2._denominator + r2._numerator * (int)r1._denominator;
            RationalNumbers r3 = new RationalNumbers(newNumerator, newDenominator);
            r3 = r3.Reduction();
            return r3;
        }

        public static RationalNumbers operator -(RationalNumbers r1, RationalNumbers r2)
        {
            uint newDenominator = r1._denominator * r2._denominator;
            int newNumerator = r1._numerator * (int)r2._denominator - r2._numerator * (int)r1._denominator;
            RationalNumbers r3 = new RationalNumbers(newNumerator, newDenominator);
            r3 = r3.Reduction();
            return r3;

        }

        public static RationalNumbers operator ++(RationalNumbers r1)
        {
            int newNumerator = r1._numerator + ((int)r1._denominator);
            RationalNumbers r3 = new RationalNumbers(newNumerator, r1._denominator);
            r3 = r3.Reduction();
            return r3;
        }

        public static RationalNumbers operator --(RationalNumbers r1)
        {
            int newNumerator = r1._numerator - ((int)r1._denominator);
            RationalNumbers r3 = new RationalNumbers(newNumerator, r1._denominator);
            r3 = r3.Reduction();
            return r3; ;
        }

        public static explicit operator float(RationalNumbers r1)
        {
            return (float)r1._numerator;
        }

        public static explicit operator int(RationalNumbers r1)
        {
            return (int)r1._numerator;
        }

        public static RationalNumbers operator *(RationalNumbers r1, RationalNumbers r2)
        {
            int newNumerator = r1._numerator * r2._numerator;
            uint newDenominator = r1._denominator * r2._denominator;
            RationalNumbers r3 = new RationalNumbers(newNumerator, newDenominator);
            r3 = r3.Reduction();
            return r3;
        }

        public static RationalNumbers operator /(RationalNumbers r1, RationalNumbers r2)
        {
            int newNumerator = r1._numerator * (int)r2._denominator;
            uint newDenominator = r1._denominator * (uint)r2._numerator;
            RationalNumbers r3 = new RationalNumbers(newNumerator, newDenominator);
            r3 = r3.Reduction();
            return r3;
        }

        public static RationalNumbers operator %(RationalNumbers r1, RationalNumbers r2)
        {
            int newNumerator = r1._numerator * (int)r2._denominator;
            uint newDenominator = r1._denominator * (uint)r2._numerator;
            RationalNumbers r3 = new RationalNumbers(newNumerator, newDenominator);
            r3 = r3.Reduction();

            r3._numerator = r3._numerator / (int)r3._denominator;
            r3._denominator = 1;

            return r3;
        }


        public RationalNumbers Reduction()
        {
            RationalNumbers r;
            int[] red = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            int denInt = (int)_denominator;
            bool isRat = true;
            int index = 0;

            do
            {
                foreach (var i in red)
                {
                    if (_numerator % i == 0 && denInt % i == 0)
                    {
                        _numerator /= i;
                        denInt /= i;
                        break;
                    }
                    index++;
                    if (red.Length - 1 == index)
                    {
                        isRat = false;
                    }
                }
            } while (isRat);

            _denominator = (uint)denInt;
            r = new RationalNumbers(_numerator, _denominator);
            return r;
        }

        public override string ToString()
        {
            if (_numerator != 0)
            {
                string rtn = $"{_numerator}/{_denominator}";
                return rtn;
            }
            else
            {
                return ZERO;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumbers rational1 = new RationalNumbers(15,7);
            RationalNumbers rational2 = new RationalNumbers(7,8);
            RationalNumbers rational3 = new RationalNumbers(17,8);

            RationalNumbers rational4 = new RationalNumbers(10, 18);
            RationalNumbers rational5 = new RationalNumbers(15, 21);
            RationalNumbers rational6 = new RationalNumbers(36, 18);

            RationalNumbers rational7 = new RationalNumbers(6, 3);
            RationalNumbers rational8 = new RationalNumbers(8, 3);

            RationalNumbers rational9 = new RationalNumbers(10, 3);
            RationalNumbers rational10 = new RationalNumbers(3, 3);

            RationalNumbers rational11 = new RationalNumbers(4, 7);
            RationalNumbers rational12 = new RationalNumbers(8, 21);

            Console.WriteLine(rational1 == rational2);
            Console.WriteLine(rational1 != rational2);

            Console.WriteLine(rational1.Equals(rational2));

            Console.WriteLine(rational1.ToString());

            Console.WriteLine(rational1 > rational2);
            Console.WriteLine(rational1 > rational3);
            Console.WriteLine(rational1 < rational3);

            Console.WriteLine("************************");

            Console.WriteLine(rational1 + rational2);
            Console.WriteLine(rational1 - rational2);

            Console.WriteLine(rational1++);
            Console.WriteLine(rational1--);
            Console.WriteLine("************************");

            Console.WriteLine(rational4.Reduction());
            Console.WriteLine(rational5.Reduction());
            Console.WriteLine(rational6.Reduction());
            Console.WriteLine(rational1.Reduction());

            Console.WriteLine((float)rational1);
            Console.WriteLine((int)rational1);

            Console.WriteLine(rational11 / rational12);
            Console.WriteLine(rational1 / rational1);

            Console.WriteLine("************************");

            Console.WriteLine(rational1 % rational1);
            Console.WriteLine(rational7 % rational8);
            Console.WriteLine(rational9 % rational10);
        }
    }
}
