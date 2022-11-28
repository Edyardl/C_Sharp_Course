// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

int b_1 = int.Parse(Console.ReadLine());
int b_2 = int.Parse(Console.ReadLine());
int b_3 = int.Parse(Console.ReadLine());

if (b_1<b_2)
{
    b_1 = b_2;
}
if (b_1<b_3)
{
    b_1 = b_3;
}
Console.Write($"The number {b_1} is the largest!");
