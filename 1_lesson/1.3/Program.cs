// Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите число: ");
String w = Console.ReadLine();
int N = int.Parse(w);
int NetN =- N;

while(NetN <= N)
{
    Console.Write($"{NetN} ");
    NetN +=1;
}
