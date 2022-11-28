// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.


string a_b_1 = Console.ReadLine();
string a_b_2 = Console.ReadLine();

int b_1 = int.Parse(a_b_1);
int b_2 = int.Parse(a_b_2);

if (b_1>b_2)
{
    Console.Write($"The number {b_1} is greater than {b_2}");
}
else if (b_1 == b_2)
{
    Console.Write($"The number {b_1} is equal to the number {b_2}");
}
else
{
    Console.Write($"The number {b_2} is greater than {b_1}");
}