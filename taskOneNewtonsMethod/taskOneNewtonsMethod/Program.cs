using System;

namespace NewtonsMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            double n = double.Parse(Console.ReadLine()); 

            Console.Write("Введите A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Введите eps: ");
            double eps = double.Parse(Console.ReadLine());

            Console.WriteLine("Результат, возвращаемый нашим методом: " + SqrtN(n, A, eps));

            Console.WriteLine("Результат, возвращаемый методом Math.Pow: " + Math.Pow(A,(1/n)));
            Console.ReadKey(); 
        }
        static double SqrtN(double n, double A, double eps) 
        {
            var x0 = A / n; 
            var x1 = (1 / n) * ((n - 1) * x0 + A / Math.Pow(x0, n - 1)); 

            while (Math.Abs(x1 - x0) > eps) 
            {
                x0 = x1; 
                x1 = (1 / n) * ((n - 1) * x0 + A / Math.Pow(x0, n - 1)); 
            }
            return x1; 
        }
    }
}