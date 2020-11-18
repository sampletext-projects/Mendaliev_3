using System;

namespace Mendaliev_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //В зависимости от языка системы дробные числа с точкой не конвертируются из строк
            //поэтому точки вручную заменяем на запятые
            //.Replace(".", ",")

            Console.WriteLine("Введите alpha: ");
            double alpha = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.WriteLine("Введите betaZero: ");
            double betaZero = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.WriteLine("Введите betaK: ");
            double betaK = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.WriteLine("Введите deltaBeta: ");
            double deltaBeta = double.Parse(Console.ReadLine().Replace(".", ","));

            double alpha2 = alpha * alpha;
            double eAlpha = Math.Pow(Math.E, alpha);

            for (double beta = betaZero; beta < betaK; beta += deltaBeta)
            {
                double znamen = eAlpha - beta * beta + Math.Tan(beta);
                double L = (24.2 * Math.Cos(alpha2) + Math.Sin(alpha + beta)) /
                           (Math.Sign(znamen) * Math.Pow(Math.Abs(znamen), 1 / 3.0));
                Console.WriteLine("L({0:F}) = {1:F}", beta, L);
            }
        }
    }
}