using System.ComponentModel.Design;
using System.Reflection;


try
{
    double a;
    Console.Write("Введите первое число ");
    while (!double.TryParse(Console.ReadLine(), out a))
    {
        Console.WriteLine("Ошибка ввода. Пожалуйста, введите число.");
    }

    Console.Write("Введите знак: + - / * ");
    string c = Console.ReadLine() ?? "";
    while (c != "+" && c != "-" && c != "/" && c != "*")
    {
        Console.WriteLine("Ошибка ввода. Пожалуйста, введите знак: + - / * ");
        c = Console.ReadLine() ?? "";
    }

    double b;
    Console.Write("Введите второе число ");
    while (!double.TryParse(Console.ReadLine(), out b))
    {
        Console.WriteLine("Ошибка ввода. Пожалуйста, введите число.");
    }

    double result = 0;

    if (c == "+") result = a + b;
    else if (c == "-") result = a - b;
    else if (c == "/") result = a / b;
    else if (c == "*") result = a * b;

    Console.WriteLine($"Результат: {result}");

}

catch (Exception ex)
{
    Console.WriteLine($"Произошла ошибка: {ex.Message}");
}


Console.Write("Сколько чисел хотите отсортировать: ");
int n = int.Parse(Console.ReadLine());

double[] numbers = new double[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Введи число: ");
    numbers[i] = double.Parse(Console.ReadLine());
}

Console.Write("Как сортировать? 1 - по возрастанию, 2 - по убыванию: ");
string choice = Console.ReadLine();

for (int i = 0; i < n; i++)
{
    for (int j = i + 1; j < n; j++)
    {
        if (numbers[i] > numbers[j])
        {
            double temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }
    }
}

if (choice == "1")
{
    Console.WriteLine("По возрастанию:");
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(numbers[i]);
    }
}
else
{
    Console.WriteLine("По убыванию:");
    for (int i = n - 1; i >= 0; i--)
    {
        Console.WriteLine(numbers[i]);
    }
}

