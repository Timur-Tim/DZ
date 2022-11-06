//  Задайте массив вещественных чисел.

// double[] GetArray(int size, int minValue, int maxValue)             // Передаем методу 3 аргумента. Размер массива, 2 велечины для рандома
// {
//     double[] res = new double[size];                                // Создаем массив вещественных чисел. Пока пустой. Размером size
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);         //В цикле сначала записываем в i-тый элемент массива случайное целое число
//         double number;                                              //Создаем дополнительную переменную для вещественной части number
//         Random rnd = new Random();
//         number = rnd.NextDouble();                                  //С помощью nextdouble записываем в нее какую-то дробь
//         res[i] = res[i] * number;                                   //Умножаем целую часть на дробную. Получаем какое-то вещественное число.
//         res[i] = Math.Round(res[i], 2);                             //Округляем до двух знаков после запятой с помощью метода встроенного math. Round
//         Console.Write($"{res[i]} ");
//     }
//     return res;
// }

// ПРИМЕР С ЛЕКЦИИ 4.
// int[,] matrix = new int [3,4];
// for (int i = 0; i < matrix.GetLength(0); i++)       // НОЛЬ - означает количество строк (3)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)   // ОДИН - количество столбцов (4)
//     {
//           Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }

// ПРИМЕР С ЛЕКЦИИ 4. с функцией


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)       // НОЛЬ - означает количество строк (3)
    {
        for (int j = 0; j < matr.GetLength(1); j++)   // ОДИН - количество столбцов (4)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j< matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}


int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);