// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

int b_1 = int.Parse(Console.ReadLine());

if (b_1 % 2 ==0)
{
    Console.Write($"The number {b_1} is even");
}
else
{
    Console.Write($"The number {b_1} is odd");
}
