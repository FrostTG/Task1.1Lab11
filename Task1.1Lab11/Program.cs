using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Разработать структуру для решения линейного уравнения 0=kx+b. Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа. 
            Для решения уравнения предусмотреть метод Root. Создать экземпляр разработанной структуры. Осуществить использование экземпляра в программе.*/

            while (true)
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("Представлено линейное уравнение 0 = kx + b");
                    Console.Write("Введите k=");
                    double k = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите b=");
                    double b = Convert.ToDouble(Console.ReadLine());
                    LineEq lineEq = new LineEq(k, b);
                    double x = Root(k, b);
                    Console.WriteLine("x={0:f2}", x);
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка! {0}", ex.Message);
                    Console.ReadLine();
                    continue;
                }
            }
        }
        static double Root(double k, double b)
        {
            double x = (k != 0) ? -b / k :0;
            return x;
        }
        struct LineEq
        {
            public double k;
            public double b;
            public LineEq(double k, double b)
            {
                this.k = k;
                this.b = b;
            }
        }
    }
}