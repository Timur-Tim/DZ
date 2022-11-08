// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("\nВведите количество элементов массива\t");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] Arr = new int[n];

// int [] FillArray(int[] Arr)
// {
//     for (int i = 0; i < Arr.Length; i++)
//     {
//         Console.Write($"\n Введите нужный элементов массива под индексом {i}: ");
//         Arr[i] = int.Parse(Console.ReadLine());
//     }    
//     return Arr;
// }

// void PrintArray(int[] Arr)
// {
//     for (int i = 0; i < Arr.Length; i++)
//     {
//         Console.Write($"{Arr[i]} ");
//     }
//     Console.WriteLine();
// }
// void SumNumbers(int[] Arr)
// {
//     int sum = 0;
//     for (int i = 0; i < Arr.Length; i++)
//     {
//      if (Arr[i] > 0) sum ++; 
//     }
//     Console.WriteLine($"Чисел больше нуля: {sum}");
// }

// int[] mas = FillArray(Arr);
// PrintArray(mas);
// SumNumbers(Arr);


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.


// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = -(b1 - b2)/(k1 - k2);
double y = k1 * x + b1;

x = Math.Round(x, 3);
y = Math.Round(y, 3);

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");