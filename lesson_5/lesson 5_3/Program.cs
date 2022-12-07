// 3. Задайте одномерный массив из 123 случайных чисел. 
//    Найдите количество элементов массива, значения которых лежат в отрезке [10,99].



void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

    int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(-1, 11);
    return arr;
}

int[] PairsNum(int[] arr) {     int size = arr.Length;     int flex_size = size / 2 + size % 2;     int[] new_arr = new int[flex_size];      for (int i = 0; i < size / 2; i++)         new_arr[i] = arr[i] * arr[size - i - 1];      if (new_arr[flex_size - 1] == 0)         new_arr[flex_size - 1] = arr[flex_size - 1];     return new_arr; 