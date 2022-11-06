// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.


// Console.WriteLine("Введите трехзначное число");
// int x = Convert.ToInt32(Console.ReadLine());
// int y = x/10;
// int z = y%10;
// Console.WriteLine($"{z}");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

// Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// int y = 0;
// if (x <= 99) Console.WriteLine("третьего числа нет");
// else if (x <= 999)
// {
//     y = x % 10; Console.WriteLine("Третье число " + y);
// }
// else if (x <= 9999) 
// {
//     y = x % 100 / 10; Console.WriteLine("Третье число " + y);
// }
// else if (x <= 99999) 
// {
//     y = x % 1000/100; Console.WriteLine("Третье число " + y);
// }
// else if (x <= 999999) 
// {
//     y = x % 10000/1000; Console.WriteLine("Третье число " + y);
// }
// else if (x <= 9999999) 
// {
//     y = x % 100000/10000; Console.WriteLine("Третье число " + y);
// }



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7");
int x = Convert.ToInt32(Console.ReadLine());
int y = 7;
if (x == 1 || x == 2 || x == 3 || x == 4 || x == 5) Console.WriteLine("Не выходной");
else if (x == 6 || x ==7) Console.WriteLine("Выходной! xD");
else if (x > y) Console.WriteLine("Не верное число"); 