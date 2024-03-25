using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void GetVolumeSphere(double a, out double v, out double s)
        {
            v = a * a * a;
            s = 6 * a * a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра");
            double a = Convert.ToDouble(Console.ReadLine());
            double v;
            double s;
            GetVolumeSphere(a, out v, out s);
            Console.WriteLine("{0},{1}",v,s);
            Console.ReadKey();
        }
    }
}
