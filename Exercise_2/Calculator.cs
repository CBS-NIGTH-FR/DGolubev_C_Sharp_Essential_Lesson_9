using System;


namespace Exercise_2
{
    enum ArithmeticOperations
    {
        Addition = 1,
        Subtraction,
        Multiplying,
        Division
    }
    static class Calculator
    {
        delegate double MyDelegate(double a, double b);
        delegate double NumsEnter();
        public static double Num1{ get; private set; }
        public static double Num2 { get; private set; }
        public static void SelectOperation(ArithmeticOperations operations)
        {

            switch ((int)operations)
            {
                case 1:
                    {
                        EnterNums();
                        MyDelegate Addition = (double a, double b) => { return a + b; };
                        double result = Addition(Num1, Num2);
                        Console.WriteLine($"Ответ:  {result}");
                        break;
                    }
                case 2:
                    {
                        EnterNums();
                        MyDelegate Subtraction = (double a, double b) => { return a - b; };
                        double result = Subtraction(Num1, Num2);
                        Console.WriteLine($"Ответ:  {result}");
                        break;
                    }
                case 3:
                    {
                        EnterNums();
                        MyDelegate Multiplying = (double a, double b) => { return a * b; };
                        double result = Multiplying(Num1, Num2);
                        Console.WriteLine($"Ответ:  {result}");
                        break;
                    }
                case 4:
                    {
                        EnterNums();
                        #region Проверка деления на НОЛЬ
                        while (Num2 == 0)
                        {
                            if (Num2 == 0)
                            {
                                NumsEnter num2 = () => { Console.WriteLine("На ноль делить нельзя, введите новое число"); return Convert.ToDouble(Console.ReadLine()); };
                                Num2 = num2();
                            }
                        }
                        #endregion
                        #region Проверка деления на НОЛЬ в лямбда операторе при помощи тернарного оператора
                        MyDelegate Division = (double a, double b) => b != 0 ? a / b : 0;
                        #endregion
                        double result = Division(Num1, Num2);
                        Console.WriteLine($"Ответ:  {result}");
                        break;
                    }
            }

        }
        private static (double, double) EnterNums()
        {
            Console.WriteLine("Введите первое число");
            NumsEnter num1 = () => Convert.ToDouble(Console.ReadLine());
            Num1 = num1();
            Console.WriteLine("Введите второе число");
            NumsEnter num2 = () => Convert.ToDouble(Console.ReadLine());
            Num2 = num2();
            return (Num1, Num2);
        }

    }
}
