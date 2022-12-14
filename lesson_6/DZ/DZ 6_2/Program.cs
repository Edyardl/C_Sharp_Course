﻿// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, 
// k1, b2 и k2 задаются пользователем.

void Intersection(double r1, double b1, double r2, double b2)
{
    double k_sub = r1 - r2;
    if (k_sub != 0)
    {
    double x = (b2 - b1) / (r1 - r2);
    double y = r1 * x + b1;
    Console.WriteLine($"Intersection point: ({x}; {y})");
    }
    else if (r1 == r2 && b1 == b2)
    Console.WriteLine("There are an infinite number of intersection points.");
else
    Console.WriteLine("There is no intersection point");

}

Intersection(int.Parse(Console.ReadLine()),
             int.Parse(Console.ReadLine()),
             int.Parse(Console.ReadLine()),
             int.Parse(Console.ReadLine()));