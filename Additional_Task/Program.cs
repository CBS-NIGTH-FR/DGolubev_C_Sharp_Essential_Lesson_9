using System;

namespace Additional_Task
{
    class Program
    {
        delegate double Average(double a, double b, double c); 
        static void Main(string[] args)
        {
            Average average = (double a, double b, double c) => { return (a + b + c) / 3; };
            Console.WriteLine("Введите первое число");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Среднее арифметическое чисел: {num1}, {num2}, {num3} равно - {Math.Round( average(num1, num2, num3), 2)}");
            Console.ReadKey();
        }
    }
}
