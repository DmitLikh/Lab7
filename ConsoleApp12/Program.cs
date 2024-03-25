using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static double GetSquare(double a, double b, double c)
        {
            double pp = (a + b + c) / 2;
            return Math.Sqrt(pp * (pp - a) * (pp - b) * (pp - c));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения сторон первого треугольника");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());
            double s1 = GetSquare(a1, b1, c1);
            Console.WriteLine("Введите значения сторон второго треугольника");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            double s2 = GetSquare(a2, b2, c2);

            if (s1 > s2)
                Console.WriteLine("Площадь первого треугольника больше");
            else
                if (s1 < s2)
                Console.WriteLine("Площадь второго треугольника больше");
            else
                Console.WriteLine("Площади треугольников равны");
            Console.ReadKey();


        }
    }
}
