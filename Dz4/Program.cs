// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число");
// double x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// double y = Convert.ToInt32(Console.ReadLine());
// double result = 0;

// void Degree (double result)
// {
//     result= Math.Pow(x, y);
//     Console.WriteLine(result);
// }
// Degree(result);



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое число");
int x = Convert.ToInt32(Console.ReadLine());

void SumNumber (int x)
{
    int razryad = 1;
    while (x % 10 > 0)
    {
        razryad ++;
        x/=10;
    
    for (int i = 1; i <= razryad; i=i*i) Console.WriteLine(i);
    }
    
}
SumNumber(x);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33