// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 7 -2 -85
// 1 -3 8 -9
// 8 7 -7 9

// Console.Write("Write count or rows: ");
// int m = int.Parse(Console.ReadLine()!);

// Console.Write("Write count or columns: ");
// int n = int.Parse(Console.ReadLine()!);

// int[,] coll = GetDoubleArray(m, n, -100, 100);
// PrintDoubleArray(coll);





// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 4, j = 2 -> такого числа в массиве нет
// i = 1, j = 2 -> 2

// Console.Write("Write element row position (i): ");
// int i = int.Parse(Console.ReadLine()!);

// Console.Write("Write element column position (j): ");
// int j = int.Parse(Console.ReadLine()!);

// int[,] collection = GetDoubleArray(6, 5, -100, 100);
// PrintDoubleArray(collection);

// Console.WriteLine();

// ElementOnPosition(collection, i, j);





// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// ВОПРОС 1: в примере в задаче указан один знак после запятой. Однако в примере почему-то указано 4,6, вместо 4,7 (аналогично для второго и третьего столбцов). 
// Подскажите, пожалуйста, это опечатка в примере или все же нужно было каким-то образом "обрезать" знаки, а не округлять?
// Если да, то подскажите, как это можно было бы сделать?
// Пробовала конвертировать в строку, но даже так происходит округление:
// Опробованные варианты:
// Вариант 1
// double result = sumPerColumn / array.GetLength(0);
// Console.Write($"{result.ToString("#.##")} "); - округляет
// Вариант 2
// Console.WriteLine(string.Format("{0:F1}", 123.6666666)); - вот такой подход тоже округляет и выводит 123,7. Это просто как пример, который был опробован.

// ВОПРОС 2: Подскажите, пожалуйста, как можно было бы обеспечить вывод результата согласно указанному в примере - через точку с запятой и точкой в конце?
// И еще и в одну строку с фразой "Среднее арифметическое каждого столбца"
// Вот такой подход не сработал: Console.WriteLine($"Среднее арифметическое для каждого столбца + {AvgPerColumn(list)}");
// Пишет, что не удается преобразовать формат void в System.ReadOnlySpan<char>.
// Получается, что мы не можем, как с переменными, указывать методы в строке с выводом Console.Write? (через $ или +) Или (что скорее) я просто что-то не так написала?


// int[,] list = GetDoubleArray(5, 6, 1, 10);
// PrintDoubleArray(list);

// Console.WriteLine("Среднее арифметическое для каждого столбца: ");

// AvgPerColumn(list);





// METHODS for using

int[,] GetDoubleArray(int rows, int columns, int minValue, int maxValue) // заполнить двумерный массив с целыми случайными числами в интервале от и до (включит-но)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return array;
}

void PrintDoubleArray(int[,] array) // вывести двумерный массив с целыми числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ElementOnPosition(int[,] array, int i, int j) // найти элемент массива по позиции строки и столбца
{
    if (i < array.GetLength(0) && j < array.GetLength(1))
    {
        Console.WriteLine($"Element on position ({i},{j}) is {array[i, j]}.");
    }
    else
    {
        Console.WriteLine($"There is no element on position ({i},{j}).");
    }
}

void AvgPerColumn(int[,] array) // посчитать и вывести среднее арифм.для каждого столбца в двумерном массиве с целыми числами
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sumPerColumn = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumPerColumn += array[i, j];
        }

        double result = sumPerColumn / array.GetLength(0);
        Console.Write($"{result:f1} ");
    }
}