using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Triangle
    {
        public Triangle()
        {
            InputSides();
        }

        private double a;
        private double b;
        private double c;
        private double square;
        private string typeOfTriangle;

        private void InputSides()
        {
            try
            {
                Console.Write("Сторона а = ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Сторона b = ");
                b = Convert.ToInt32(Console.ReadLine());

                Console.Write("Сторона c = ");
                c = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Данные были введены в неправильном формате!\n");
                throw;
            }

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Стороны треугольника должны быть больше 0!");
                Environment.Exit(13);
            }
        }

        private void AreaOfTriangle()
        {
            
            if ((b + c > a) && (a + c > b) && (a + b > c))
            {
                double p = ((a + b + c) / 2);

                square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else
            {
                Console.WriteLine("Треугольник с введенными сторонами не может существовать!");
                Environment.Exit(13);
            }
        }

        private string TypeOfTriangle()
        {
            if (a == b || a == c || b == c)
            {
                if (a == b && a == c)
                {
                    return "равносторонний";
                }
                else
                {
                    return "равнобедренный";
                }
            }
            else
            {
                return "разносторонний";
            }
        }

        public void TriangleInfo()
        {
            AreaOfTriangle();
            typeOfTriangle = TypeOfTriangle();

            Console.WriteLine($"\n\tTRIANGLE INFO\nСтороны: А = {a}, B = {b}, C = {c}\nВид: {typeOfTriangle}\nПлощадь: {square}");
        }

    }
}
