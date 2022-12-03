// Напишите программу, которая принимает на вход координаты точки (X и Y),
// ричём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

void Quarters(string a)
{ 
    if (a == "I")
         Console.WriteLine("x > 0 and y > 0");
    else if (a == "II")
         Console.WriteLine("x < 0 and y > 0");
    else if (a == "III")
         Console.WriteLine("x < 0 and y < 0");
    else if (a == "IV")
         Console.WriteLine("x > 0 and y <  0");
    else          
         Console.WriteLine("error");
         
} 

Quarters(Console.ReadLine());

