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


// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)       // НОЛЬ - означает количество строк (3)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)   // ОДИН - количество столбцов (4)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j< matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }


// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// РИСУЕМ КАРТИНКУ!!!!!!!!!!!!!!!!!


// int[,] matrix = new int[23, 25];
// int[,] pic = new int[23, 25];

// void PrintImage(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             if (image[i, j] == 0) Console.Write($" ");
//             else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }
// }
// void FillImage(int row, int col)                                  // ТУТ ДОЛЖНА БЫТЬ КАРТИНКА, НО У МЕНЯ НЕ ВЫШЛО))
// {
//     if (pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FillImage(row - 1, col);
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);
//     }
// }
// PrintImage(pic);
// FillImage(13, 13);
// PrintImage(pic);



// double Factorial(int n)
// {
//     if (n == 1) return 1;     //0! и 1! = 1
//     else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }

// f(1)= 1, f(2) = 1, f(n) = f(n-1) + f(n - 2)
// double Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine(Fibonacci(i));
// }
