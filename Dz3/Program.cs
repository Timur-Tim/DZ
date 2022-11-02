// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
//Через строку решать нельзя.

// Console.WriteLine("Введите пятизначное число");
// int x = Convert.ToInt32(Console.ReadLine());
// int y1 = 0;
// int y2 = 0;
// int y4 = 0;
// int y5 = 0;

// if (x <= 99999 && x >= 10000)
// {
//     y1 = x % 10;  //пятое число
//     y2 = x % 100 / 10;  //четвертое число
//     y4 = x % 10000 / 1000;  // второе число
//     y5 = x % 100000 / 10000;  //первое число
//     if (y5 == y1 && y4 == y2) Console.WriteLine("Молодец. Палиндром");
//     else 
//     Console.WriteLine("Эхх... Не палиндром");
// }
// else if (x < 10000)
//     Console.WriteLine("Некорректное число");
// else if (x > 99999)
//     Console.WriteLine("Некорректное число");



// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Console.WriteLine("Введите координаты x точки a");
// int ax = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y точки a");
// int ay = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты z точки a");
// int az = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты x точки b");
// int bx = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y точки b");
// int by = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты z точки b");
// int bz = Convert.ToInt32(Console.ReadLine());

// double dist = Math.Sqrt(Math.Pow(bx-ax, 2) + Math.Pow(by-ay, 2) + Math.Pow(bz-az, 2));
// Console.WriteLine($"Расстояние между точками равно {dist}");



// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Console.WriteLine("Введите натуральное число");
// int x = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= x; i++) Console.Write(Math.Pow(i, 3) + " ");