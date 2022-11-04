// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] CreateFillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

void HonestArray(int[] numbers)
{
    
    int a = 0;
    for (int z = 0; z < numbers.Length; z++)
    {
        if (numbers [z] % 2 == 0) a++;
    }
    Console.Write($"Всего чётных чисел {a}");
} 

int[] numbers = CreateFillArray(size);
HonestArray(numbers);

// int[] mas = CreateFillArray();
// int[] res = HonestArray();

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];

// int[] CreateFillArray()
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
// int[] mas = CreateFillArray();

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.