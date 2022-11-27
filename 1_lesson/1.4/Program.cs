//  Напишите программу вычисления модуля числа.

Console.WriteLine("Введите число: ");
var t = Console.ReadLine();
int N = t == null ? 0 : int.Parse(t);
Console.WriteLine($"{Math.Abs(N)}");
