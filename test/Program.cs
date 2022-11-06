// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.


Console.WriteLine("Введите трехзначное число");
int x = Convert.ToInt32(Console.ReadLine());

if (x > 100 && x < 1000)
{
    int y = x / 10;
    int z = y % 10;
    Console.WriteLine($"{z}");
}
else
    Console.WriteLine($"Не верное число");

double[] GetArray(int size, int minValue, int maxValue) // Передаем методу 3 аргумента. Размер массива, 2 велечины для рандома
{
    double[] res = new double[size]; // Создаем массив вещественных чисел. Пока пустой. Размером size
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1); //В цикле сначала записываем в i-тый элемент массива случайное целое число
        double number;        //Создаем дополнительную переменную для вещественной части number
        Random rnd = new Random();
        number = rnd.NextDouble();   //С помощью nextdouble записываем в нее какую-то дробь
        res[i] = res[i] * number;   //Умножаем целую часть на дробную. Получаем какое-то вещественное число.
        res[i] = Math.Round(res[i], 2);  //Округляем до двух знаков после запятой с помощью метода встроенного math. Round
        Console.Write($"{res[i]} ");
    }
    return res;
}