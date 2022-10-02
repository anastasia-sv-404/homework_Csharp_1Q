// Все массивы от 5-ти элементов

// ЗАДАЧА 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] array = FullfillArray(10, 100, 999);
// Console.WriteLine($"[{String.Join(", ", array)}]");
// Console.WriteLine($"Количестве четных чисел в массиве равно {GetCountEven(array)}.");

// int GetCountEven(int[] collection)
// {
//     int count = 0;

//     for(int i = 0; i < collection.Length; i++)
//     {
//         if(collection[i] % 2 == 0)
//         {
//         count++;
//         }
//     }
    
//     return count;
// }





// ЗАДАЧА 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = FullfillArray(10, -10, 10);
// Console.WriteLine($"[{String.Join(", ", array)}]");
// Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях, равна {GetSumOddPosition(array)}.");

// int GetSumOddPosition (int[] coll)
// {
// int sum = 0;

// for(int y = 0; y < coll.Length; y++)
// {
//     if(y % 2 !=0)
//     {
//         sum += coll[y];
//     }
// }

// return sum;
// }


// Метод для формирования массива заданной величины, заполненного случайными числами типа int
// int[] FullfillArray(int length, int minValue, int maxValue)
// {
//     int[] array = new int[length];
    
//     for(int x = 0; x < array.Length; x++)
//     {
//         array[x] = new Random().Next(minValue, maxValue + 1);
//     }

//     return array;
// }





// ЗАДАЧА 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] array = GetArrayDouble(10, -10, 10); // ВАРИАНТ 1 для метода, который задает массив с веществ.числами - через конвертацию int в double (c учетом данных в примере: нет знаков после запятой)
// Console.WriteLine($"[{String.Join(" ", array)}]");
// double result = GetDifferenceMaxMin(array);
// Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {result}.");


// double[] array1 = GetArrayDouble1(10, -1.1 , 5.8); // ВАРИАНТ 2 для метода, который задает массив с веществ.числами - через new Random().NextDouble() и Math.Round
// Console.WriteLine($"[{String.Join(" ", array1)}]");
// double result1 = GetDifferenceMaxMin(array1);
// Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {result1}.");


// double[] GetArrayDouble(int length, int minValue, int maxValue)
// {
//     double[] array = new double[length];
    
//     for(int x = 0; x < array.Length; x++)
//     {
//         array[x] = Convert.ToDouble(new Random().Next(minValue, maxValue + 1));
//     }

//     return array;
// }


// double[] GetArrayDouble1(int length, double minValue, double maxValue)
// {
//     double[] array = new double[length];
    
//     for(int x = 0; x < array.Length; x++)
//     {
//         double y = new Random().NextDouble(); // генерирует случайное веществ число от 0 до 1
//         array[x] = Math.Round(y * (maxValue - minValue) + minValue, 0); // формула приводит число y к отрезку от minV до maxV  - умножение на длину, чтоб не выйти за maxV, прибавляем minV, чтоб не остаться левее minV
//     }// Math.Round - математическое округление, кол-во знаков указывается после запятой

//     return array;
// }



// double GetDifferenceMaxMin(double[] array2)
// {
// int i = 0;
// double max = array2[i]; 
// double min = array2[i];

// for ( ; i < array2.Length; i++)
// {
//     if(array2[i] > max)
//     {
//         max = array2[i];
//     }
//     else if(array2[i] < min)
//     {
//         min = array2[i];
//     }
// }

// double difference = max - min; 
// return difference;
// }








