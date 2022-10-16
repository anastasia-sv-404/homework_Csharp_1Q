// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Исходный двумерный массив: ");
// int[,] collection = GetDoubleArray(5, 10, -100, 100);
// PrintDoubleArray(collection);

// Console.WriteLine();
// Console.WriteLine("Двумерный массив, для которого упорядочены по убыванию элементы каждой строки: ");

// int[,] collectionNew = GetArrayDescendingSortPerRows(collection);
// PrintDoubleArray(collectionNew);





// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.WriteLine("Исходный двумерный массив: ");
// int[,] collection = GetDoubleArray(5, 5, 1, 10);
// PrintDoubleArray(collection);

// int[] sumArray = new int[collection.GetLength(0)];

// for (int i = 0; i < collection.GetLength(0); i++)
// {
//     sumArray[i] = SumPerRowDoubleArray(collection, i);
// }

// int minSum = sumArray[0];
// int minPosition = 0;

// for (int j = 0; j < sumArray.Length; j++)
// {
//     if (sumArray[j] < minSum)
//     {
//         minSum = sumArray[j];
//         minPosition = j;
//     }
// }

// Console.WriteLine($"Суммы элементов по каждой строке исходного массива: [{String.Join(", ", sumArray)}]");
// Console.WriteLine($"Минимальная сумма элементов - это {minSum}.");
// Console.WriteLine($"Номер строки исходного массива с наименьшей суммой элементов - это {minPosition}.");







// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// Прим: операция умножения двух матриц выполнима только в том случае, если число столбцов в первом сомножителе равно числу строк во втором; в этом случае говорят, что матрицы согласованы.


// Console.WriteLine("Матрица 1: ");
// int[,] matrixFirst = GetDoubleArray(2, 3, 1, 9);
// PrintDoubleArray(matrixFirst);

// Console.WriteLine();

// Console.WriteLine("Матрица 2: ");
// int[,] matrixSecond = GetDoubleArray(3, 2, 1, 9);
// PrintDoubleArray(matrixSecond);

// Console.WriteLine();

// if (matrixFirst.GetLength(0) != matrixSecond.GetLength(1))
// {
//     Console.WriteLine("Матрицы должны быть согласованнными: число строк первой матрицы должно быть равно числу столбцов второй!");
// }
// else
// {
//     Console.WriteLine("Результирующая матрица: ");
//     int[,] matrixMultiplication = new int[matrixFirst.GetLength(0), matrixSecond.GetLength(1)]; // результат произведения двух матриц имеет столько же строк, как первая матрица, и столько же столбцов, как вторая матрица.

//     for (int rows = 0; rows < matrixMultiplication.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < matrixMultiplication.GetLength(1); columns++)
//         {
//             matrixMultiplication[rows, columns] = SumPerMultiple(GetRowFromArray(matrixFirst, rows), GetColumnFromArray(matrixSecond, columns));
//         }
//     }
//     PrintDoubleArray(matrixMultiplication);
// }





// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[] coll = GetUniqueArray(10, 99);

// int[,,] collection = GetTripleArray(2, 2, 2, coll, 0); // в условии задачи стоит указание только на уникальность двузначных чисел, но не на их одновременную случайность
// PrintTripleArray(collection);





// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// int startNumber = 10; // так как в описании задачи указано "например", а не "обязательно начните с 01", стартовое число задано как 10.

// int[,] array = new int[4, 4]; // решение ниже работает ТОЛЬКО для массивов 3х3, 4х4 и 5х5. С учетом условия задачи, сформированная программа видится достаточной для ее выполнения.

// for (int column = 0; column < array.GetLength(1); column++)
// {
//     array[0, column] = startNumber;
//     startNumber++;
// }

// for (int row = 1; row < array.GetLength(0); row++)
// {
//     array[row, array.GetLength(1) - 1] = startNumber;
//     startNumber++;
// }

// for (int column = array.GetLength(1) - 2; column >= 0; column--)
// {
//     array[array.GetLength(0) - 1, column] = startNumber;
//     startNumber++;
// }

// for (int row = array.GetLength(0) - 2; row > 0; row--)
// {
//     array[row, 0] = startNumber;
//     startNumber++;
// }

// int pointRowNext = 1;
// int pointColumnNext = 1;

// while (array[pointRowNext, pointColumnNext + 1] == 0)
// {
//     array[pointRowNext, pointColumnNext] = startNumber;
//     startNumber++;
//     pointColumnNext++;
// }

// while (array[pointRowNext + 1, pointColumnNext] == 0)
// {
//     array[pointRowNext, pointColumnNext] = startNumber;
//     startNumber++;
//     pointRowNext++;
// }

// while (array[pointRowNext, pointColumnNext - 1] == 0)
// {
//     array[pointRowNext, pointColumnNext] = startNumber;
//     startNumber++;
//     pointColumnNext--;
// }

// while (array[pointRowNext - 1, pointColumnNext] == 0)
// {
//     array[pointRowNext, pointColumnNext] = startNumber;
//     startNumber++;
//     pointRowNext--;
// }

// for(int rowFin = 0; rowFin < array.GetLength(0); rowFin++)
// {
//     for(int columnFin = 0; columnFin < array.GetLength(1); columnFin++)
//     {
//         if (array[rowFin, columnFin] == 0)
//         {
//             array[rowFin, columnFin] = startNumber;
//             startNumber++;
//         }
//     }
// }

// PrintDoubleArray(array);





// Рекомендовано решить(задача с семинара)
// Отсортировать нечетные столбцы массива по возрастанию. Вывести массив изначальный и массив с отсортированными нечетными столбцами

// Console.WriteLine("Исходный двумерный массив: ");
// int[,] collection = GetDoubleArray(5, 6, 0, 9);
// PrintDoubleArray(collection);

// Console.WriteLine();
// Console.WriteLine("Двумерный массив, для которого нечетные столбцы отсортированы по возрастаниюи: ");

// int[,] collectionNew = GetArrayDescendingSortPerColumns(collection);
// PrintDoubleArray(collectionNew);





// МЕТОДЫ
// Общие
int[,] GetDoubleArray(int rows, int columns, int minValue, int maxValue) // заполнить двумерный массив целыми случайными числами в интервале от и до (включит-но)
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


// Для Задачи 54
int[,] GetArrayDescendingSortPerRows(int[,] array) // упорядочить элементы по убыванию в каждой строке двумерного массива
{
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            for (int columnsNext = columns + 1; columnsNext < array.GetLength(1); columnsNext++)

                if (array[rows, columnsNext] > array[rows, columns])
                {
                    int temp = array[rows, columns];
                    array[rows, columns] = array[rows, columnsNext];
                    array[rows, columnsNext] = temp;
                }
        }
    }
    return array;
}


// Для Задачи 56
int SumPerRowDoubleArray(int[,] array, int rowNumber) // метод для подсчета суммы элементов в заданной строке двумерного массива
{
    int sumItemsPerRow = 0;

    for (int columns = 0; columns < array.GetLength(1); columns++)
    {
        sumItemsPerRow += array[rowNumber, columns];
    }

    return sumItemsPerRow;
}


// Для Задачи 58
int[] GetRowFromArray(int[,] array, int rowNumber) // вывести в виде массива заданную строку двумерного массива
{
    int[] rows = new int[array.GetLength(1)];

    for (int i = 0, columns = 0; i < rows.Length; i++, columns++)
    {
        rows[i] = array[rowNumber, columns];
    }
    return rows;
}

int[] GetColumnFromArray(int[,] array, int columnNumber) // вывести в виде массива заданный столбец двумерного массива
{
    int[] columns = new int[array.GetLength(0)];

    for (int j = 0, rows = 0; j < columns.Length; j++, rows++)
    {
        columns[j] = array[rows, columnNumber];
    };
    return columns;
}

int SumPerMultiple(int[] arrayFirst, int[] arraySecond) // сумма произведение элментов двух массивов; может быть использован, то если длины массивов равны
{
    int sum = 0;
    for (int i = 0; i < arrayFirst.Length; i++)
    {
        sum += arrayFirst[i] * arraySecond[i];
    }
    return sum;
}


// Для Задачи 60
int[] GetUniqueArray(int minValue, int maxValue) // заполнить массив последовательными числами - в заданном диапазоне от и до
{
    int[] numbers = new int[maxValue - minValue + 1];

    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = minValue + i;
    }
    return numbers;
}

int[,,] GetTripleArray(int firstdMetric, int seconddMetric, int thirdMetric, int[] collection, int startPosCollection) // задать трехмерный массив из неповторяющихся чисел
{
    int[,,] array = new int[firstdMetric, seconddMetric, thirdMetric];

    if (startPosCollection > collection.Length - firstdMetric * seconddMetric * thirdMetric)
    {
        Console.WriteLine("Введенного значения стартовой позиции недостаточно для полного заполнения трехмерного массива заданной величины.");
    }
    else
    {
        for (int i = 0; i < firstdMetric; i++)
        {
            for (int j = 0; j < seconddMetric; j++)
            {
                for (int z = 0; z < thirdMetric; z++)
                {
                    array[i, j, z] = collection[startPosCollection];
                    startPosCollection++;
                }
            }
        }
    }
    return array;
}

void PrintTripleArray(int[,,] array) // напечатать построчно трехмерный массив
{
    for (int z = 0; z < array.GetLength(2); z++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.WriteLine();

            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, z]}({i}, {j}, {z}) ");
            }
        }
    }
}


// Для рекомендованной к решению задачи (с семинара)
int[,] GetArrayDescendingSortPerColumns(int[,] array) // отсортировать нечетные столбцы двумерного массива по возрастанию
{
    for (int columns = 0; columns < array.GetLength(1); columns++)
    {
        if (columns % 2 != 0)
        {
            for (int rows = 0; rows < array.GetLength(0); rows++)
            {
                for (int rowsNext = rows + 1; rowsNext < array.GetLength(0); rowsNext++)

                    if (array[rowsNext, columns] < array[rows, columns])
                    {
                        int temp = array[rows, columns];
                        array[rows, columns] = array[rowsNext, columns];
                        array[rowsNext, columns] = temp;
                    }
            }
        }
    }
    return array;
}