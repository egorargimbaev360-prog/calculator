using System.ComponentModel.Design;
using System.Reflection;
using calculator;

Console.Write("Введите первое число ");
double a = double.Parse(Console.ReadLine());

Console.Write("Введите знак: + - / * ");
string c = Console.ReadLine();

Console.Write("Введите второе число ");
double b = double.Parse(Console.ReadLine());

double result;

if (c == "+") result = a + b;
else if (c == "-") result = a - b;
else if (c == "/") result = a / b;
else if (c == "*") result = a * b;
else
{
    Console.WriteLine("Неизсветсная операция");
    return;
}

Console.WriteLine($"Результат: {result}");



