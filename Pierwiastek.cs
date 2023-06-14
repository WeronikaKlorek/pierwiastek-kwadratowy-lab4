using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pierwiastek_kwadratowy
{
    public class Pierwiastek
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }

        public double x1 { get; set; }
        public double x2 { get; set; }

        public double obliczDelte(int a, int b, int c) {

            double delta = 0;

            // obliczanie delty na podstawie wzoru: D = b^2 - 4ac
            delta = b * b - 4 * a * c;

            return delta;
        }
        public void obliczPierwiastki(int a, int b, int c)
        {
            double delta = obliczDelte(a, b, c);
            //double x1, x2;

            switch (delta)
            {
                case 0:
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = x1;
                    Console.WriteLine($"Dla wpisanych parametrów delta przyjmuje wartość: {delta}\n" +
                        $"Miejsce zerowe to: {Math.Round(x1, 2)}");
                    break;
                case > 0:
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Dla wpisanych parametrów delta przyjmuje wartość: {delta}\n" +
                        $"Miejsca zerowa równania to: {Math.Round(x1, 2)} oraz {Math.Round(x2, 2)}");
                    break;
                case < 0:
                    x1 = x2 = double.NaN;
                    Console.WriteLine($"Delta mniejsza od zera. Brak miejsc zerowych równania");
                    break;
            }

        }

    }
}
