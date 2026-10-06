using System;
using System.Globalization;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Калькулятор: + - * и факториал (!)");

        while (true)
        {
            Console.Write("\nОперация (+, -, *, !) или q для выхода: ");
            string op = (Console.ReadLine() ?? "q").Trim().ToLower();

            if (op == "q") break;

            if (op == "!")
            {
                Console.Write("Введите целое число n (0..5000): ");
                if (int.TryParse(Console.ReadLine(), out int n) && n >= 0 && n <= 5000)
                    Console.WriteLine($"{n}! = {Factorial(n)}");
                else
                    Console.WriteLine("Нужно целое число от 0 до 5000.");
            }
            else if (op == "+" || op == "-" || op == "*")
            {
                double a = ReadNumber("Первое число: ");
                double b = ReadNumber("Второе число: ");

                double result = op switch
                {
                    "+" => a + b,
                    "-" => a - b,
                    _ => a * b
                };

                Console.WriteLine($"{a} {op} {b} = {result}");
            }
            else
            {
                Console.WriteLine("Неизвестная операция, попробуй ещё раз.");
            }
        }
    }

    static double ReadNumber(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = (Console.ReadLine() ?? "").Replace(',', '.');

            if (double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out double x))
                return x;

            Console.WriteLine("Это не число, попробуй ещё раз.");
        }
    }

    static BigInteger Factorial(int n)
    {
        BigInteger result = 1;
        for (int i = 2; i <= n; i++) result *= i;
        return result;
    }
}