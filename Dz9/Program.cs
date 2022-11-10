// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// Console.Write("Введите целое число ");
// int n = Convert.ToInt32(Console.ReadLine());
// string RecNat(int n)
// {
//     if (n == 0) return "";
//     return  Convert.ToString(n) + ", " + RecNat(n - 1);
// }
// Console.WriteLine($"{RecNat(n)}");



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите целое число ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число ");
int n = Convert.ToInt32(Console.ReadLine());

int SumRec(int m, int n)
{
    int sum = m;
    if (m == n) return n;    
    return SumRec(m, n-1) + n;
}
Console.WriteLine($" {SumRec(m, n)} ");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29