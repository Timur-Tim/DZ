// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. 

// Console.WriteLine("Введите натуральное число");
// int x = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите натуральное число");
// int y = Convert.ToInt32 (Console.ReadLine());

// if (x < y) Console.WriteLine($"Меньшее число: {x} Большее число {y}");
// else $"Большее число: {x} Меньшее число: {y}");



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Введите натуральное число");
// int x = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите натуральное число");
// int y = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите натуральное число");
// int z = Convert.ToInt32 (Console.ReadLine());

// if (x > y)
// {
// if (z > x) Console.WriteLine(z); 
// else Console.WriteLine(x);
// }
// else
// {
// if (z > y) Console.WriteLine(z);
// else Console.WriteLine(y);
// }



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


// Console.WriteLine("Введите натуральное число");
// int x = Convert.ToInt32 (Console.ReadLine());

// if (x % 2 == 0) Console.WriteLine("Четное число");
// else Console.WriteLine("Нечетное число");


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите натуральнео число");
int x = Convert.ToInt32 (Console.ReadLine());
int y = 1;
while (y < x)
{
if ((y % 2) == 0)
Console.Write($"{y}, ");
y = y + 1;
}
Console.Write($"{y} ");
if (x < 1) Console.WriteLine("Введено число меньше нуля");