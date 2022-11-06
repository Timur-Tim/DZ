// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] CreateFillArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
//     return array;
// }

// void HonestArray(int[] numbers)
// {
//     int a = 0;
//     for (int z = 0; z < numbers.Length; z++)
//     {
//         if (numbers [z] % 2 == 0) a++;
//     }
//     Console.Write($"Всего чётных чисел {a}");
// } 

// int[] numbers = CreateFillArray(size);
// HonestArray(numbers);

// int[] mas = CreateFillArray();
// int[] res = HonestArray();




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// // int[] array = new int[size];


// int[] FillArray(int size)
// // создание массива
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(1, 100);
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
//     return array;
// }
// //нахождение четных элементов 

// int EvenArray(int[] array)
// {
//     int x = 0;
//     // for(int a = 0; a < array.Length; a++);
//     // {
//         for (int i = 0; i < array.Length; i = i + 2)
//         {
//           x = x + array[i];  //(array[i] % 2 == 1)
//         }
//         Console.WriteLine(x);
//     return x;

// }
// int[] numbers = FillArray(size);
// EvenArray(numbers);



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

double[] FillArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        double number;
        Random rnd = new Random();
        number = rnd.NextDouble();
        res[i] = res[i] * number;
        res[i] = Math.Round(res[i], 2);
        Console.Write($"{res[i]} ");
    }
    return res;
}
double ResArray(double[] size)
{
    double max = size[0];
    double min = size[0];
    double sum = 0;
    for (int i = 1; i < size.Length; i++)
    {
        if (size[i] > max) max = size[i];
        if (size[i] < min) min = size[i];
    }
    sum = max - min;
    Console.Write($"Разница между максимальным {max} и минимальным {min} будет{sum}");
    return sum;
}

double[] numbers = FillArray(size, 1, 100);
double diff = ResArray(numbers);