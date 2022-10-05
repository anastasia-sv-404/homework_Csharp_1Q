// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

// Console.Write("Введите число M - количество чисел в массиве: ");
// int M = int.Parse(Console.ReadLine()!);

// int[] collection = FillArray(M, -999, 999); // Интервал и/или тип чисел, которые вводит пользователь, не указан по условию задачи.
// Console.WriteLine($"Введенные числа - это: {String.Join(", ", collection)}");

// CountPositiveNumbers(collection);

// void CountPositiveNumbers(int[] coll)
// {
//     int count = 0;
//     for (int i = 0; i < coll.Length; i++)
//     {
//         if (coll[i] > 0)
//         {
//             count++;
//         }
//     }
//     Console.WriteLine("Среди введенных чисел количество чисел больше 0 равно " + count);
// }

// // Метод для формирования массива заданной величины, заполненного случайными числами типа int
// int[] FillArray(int length, int minValue, int maxValue)
// {
//     int[] array = new int[length];

//     for (int x = 0; x < array.Length; x++)
//     {
//         array[x] = new Random().Next(minValue, maxValue + 1);
//     }

//     return array;
// }





// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Write("Введите значение b1: ");
// double b1 = double.Parse(Console.ReadLine()!); 

// Console.Write("Введите значение k1: ");
// double k1 = double.Parse(Console.ReadLine()!);

// Console.Write("Введите значение b2: ");
// double b2 = double.Parse(Console.ReadLine()!);

// Console.Write("Введите значение k2: ");
// double k2 = double.Parse(Console.ReadLine()!);

// double x = (b2 - b1) / (k1 - k2); // С учетом краткости решения и его математической "подоплёки" - решение без методов (не видится целесообразным использование).
// double y = k1 * x + b1;

// Console.Write($"Точка персечения двух прямых - это точка ({Math.Round(x, 1)}, {Math.Round(y, 1)})");


