// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] array = new double[m, n];

// double[,] FillArray(double[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().NextDouble()*100);
//         }
//     }
//     return array;
// }

// void PrintArray(double[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             Console.Write($"{image[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// double[,] mas = FillArray(array);
// PrintArray(mas);


// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение элемента");
// int x = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];

// int[,] FillArray(int m, int n)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(-10, 11);
//     }
//     return array;
// }

// void PrintArray(int[,] image)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{image[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] Search(int[,] image)
// {
//     int count = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {      
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(x == array[i,j]) 
//             { 
//                 Console.WriteLine($"Координаты числа: {i}, {j}"); 
//                 count++;         // НЕ ДОПИРАЮ!!!!             
//             }
//         }         
//     }    
//     if(count == 0) Console.WriteLine($"Такого числа нет");
//     return array;
// }

// int[,] mas = FillArray(m, n);
// PrintArray(mas);
// Search(array);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.