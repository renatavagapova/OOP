using System;

namespace lesson5._2
{
    class ComplexNumbers      //  комплексные числа     z=a+bi
    {
        /// <summary>
        /// вещественная часть a
        /// </summary>
        private double _realPart;

        /// <summary>
        /// мнимая часть bi 
        /// </summary>
        private double _imaginaryPart;

        public ComplexNumbers(double a, double bi)
        {
            _realPart = a;
            _imaginaryPart = bi;
        }

        public static bool operator ==(ComplexNumbers cn1, ComplexNumbers cn2)
        {
            if (cn1._realPart == cn2._realPart && cn1._imaginaryPart == cn2._imaginaryPart)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(ComplexNumbers cn1, ComplexNumbers cn2)
        {
            return cn1._realPart != cn2._realPart && cn1._imaginaryPart != cn2._imaginaryPart;
        }

        public static ComplexNumbers operator +(ComplexNumbers cn1, ComplexNumbers cn2)
        {
            ComplexNumbers cn3 = new ComplexNumbers(cn1._realPart + cn2._realPart, cn1._imaginaryPart + cn2._imaginaryPart);

            return cn3;
        }

        public static ComplexNumbers operator -(ComplexNumbers cn1, ComplexNumbers cn2)
        {
            ComplexNumbers cn3 = new ComplexNumbers(cn1._realPart - cn2._realPart, cn1._imaginaryPart - cn2._imaginaryPart);

            return cn3;
        }

        public static ComplexNumbers operator *(ComplexNumbers cn1, ComplexNumbers cn2)
        {
            ComplexNumbers cn3 = new ComplexNumbers(
                cn1._realPart* cn2._realPart - cn1._imaginaryPart * cn2._realPart,
                cn1._imaginaryPart* cn2._realPart + cn1._realPart * cn2._imaginaryPart);

            return cn3;
        }

        public static ComplexNumbers operator /(ComplexNumbers cn1, ComplexNumbers cn2)
        {
            ComplexNumbers cn3 = new ComplexNumbers(
                (cn1._realPart* cn2._realPart + cn1._imaginaryPart * cn2._imaginaryPart)
                / (cn2._realPart * cn2._realPart + cn2._imaginaryPart * cn2._imaginaryPart),
                (cn1._imaginaryPart * cn2._realPart - cn1._realPart * cn2._imaginaryPart)
                / (cn2._realPart * cn2._realPart + cn2._imaginaryPart * cn2._imaginaryPart));

            return cn3;
        }

        public override string ToString()
        {
            if (_realPart != 0 && _imaginaryPart != 0)
            {
                return $" {_realPart}+{_imaginaryPart}i ";
            }
            if (_realPart != 0)
            {
                return $" {_imaginaryPart}i ";
            }
            return $" {_realPart}";
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            ComplexNumbers complex1 = new ComplexNumbers(2, 5);
            ComplexNumbers complex2 = new ComplexNumbers(6, 3);
            ComplexNumbers complex3 = new ComplexNumbers(8, 4);
            ComplexNumbers complex4 = new ComplexNumbers(8, 0);
            ComplexNumbers complex5 = new ComplexNumbers(0, 5);

            Console.WriteLine(complex1);
            Console.WriteLine(complex4);
            Console.WriteLine(complex5);
            Console.WriteLine(complex1 + complex1);
            Console.WriteLine(complex1 - complex1);
            Console.WriteLine("*****************************");
            Console.WriteLine(complex1 * complex1);
            Console.WriteLine(complex1 / complex1);
            Console.WriteLine(complex1 * complex4);
            Console.WriteLine(complex2 * complex3);
        }
    }
}
