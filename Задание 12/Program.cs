using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус окружности: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату x: ");
            double x = Math.Abs(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Введите координату y: ");
            double y = Math.Abs(Convert.ToDouble(Console.ReadLine()));
            Okrujnost.Dlina(radius);
            Okrujnost.Ploshad(radius);
            Okrujnost.Koordinaty(radius, x, y);
            Console.ReadKey();
        }
        public static class Okrujnost
        {

            public static void Dlina(double radius)
            {
                {
                    double dlina = Math.PI * 2 * radius;
                    Console.WriteLine("Длина окружности равна {0}", dlina);
                }
            }

            public static void Ploshad(double radius)
            {
                double ploshad = Math.PI * Math.Pow(radius, 2.0);
                Console.WriteLine("Площадь круга равна {0}", ploshad);

            }

            public static void Koordinaty(double radius, double x, double y)
            {
                if (x <= radius && y <= radius)
                {
                    Console.WriteLine("Точка, координаты которой: x = {0}, y = {1}, принадлежит кругу радиусом {2}", x, y, radius);
                }
                else
                {
                    Console.WriteLine("Точка, координаты которой: x = {0}, y = {1}, не принадлежит кругу радиусом {2}", x, y, radius);
                }
            }
        }
    }
}
