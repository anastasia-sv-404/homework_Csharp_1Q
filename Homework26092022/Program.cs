// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число: ");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите степень числа: ");
// int B = int.Parse(Console.ReadLine()!);

// if ((B > 0))
// {
// Console.WriteLine("Выберите вариант решения: ");
// int C = int.Parse(Console.ReadLine()!);

//     if(C == 1){ 
//         Console.WriteLine($"Если возвести число {A} в степень {B}, то получим число {GetPow(A, B)}");
//     }
//     else if (C == 2){
//         Console.WriteLine($"Если возвести число {A} в степень {B}, то получим число {GetPow2(A, B)}"); // второй вариант, так как в условии задачи указано написать цикл
//     }
//     else{
//     Console.WriteLine("Такого варианта решения нет. Выберите вариант 1 или 2.");
//     }
// }
// else{
// Console.WriteLine($"Степень числа {A} должна быть натуральным числом."); 
// }


// int GetPow(int x, int y)
// {
//     int result = Convert.ToInt32(Math.Pow(x, y));
//     return result;
// }

// int GetPow2(int x, int y)
// {
//    int result = x;

//    for(int i = 1; i < y; i++){
//         result = result * x;
//    }
//     return result;
// }





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Clear();

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"Сумма цифр в числе {number} равна {SumNumbers(number)}");

// int SumNumbers(int x)
// {
//     int sum = 0;
       
//     for(int y = x, y1 = y % 10; y > 0; ) 
//     {
//         y = y / 10;
//         sum = sum + y1;
//         y1 = y % 10;       
//     }
    
//     return sum;
// }

// ВОПРОС1: описанный в решении задачи 27 цикл работает, даже когда не введена переменная i для счетчика (и нет действия_после_выполнения в виде i++ )
// Получается, что ввод доп. переменной именно для счетчика - не является обязательным действием?
// Или все же всегда нужно объявлять доп.переменную i, даже если потом эта переменная никак и нигде не будет использоваться?

// ВОПРОС2: на семинаре вы в команду array3[j] = new Random().Next(1, 10); - записали не два числа в скобках для Next, 
// а только одно - Next(2) - подскажите, пожалуйста, что это означает/как применяется?





// Задача 29: Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// ВАРИАНТ 1

// int[] collection = new int[8];

// FillArray(collection);
// PrintArray(collection);


// void FillArray(int[] array1)
// {
//     for(int i = 0; i < array1.Length; i++)
//     {
//         array1[i] = new Random().Next(0, 1000);
//     }
// }

// void PrintArray(int[] array2)
// {
//     for(int i = 0; i < array2.Length; i++)
//     {
//         Console.Write(array2[i] + " ");
//     } 
// }


// ВАРИАНТ 2 (сокращение варианта 1 + string.join)

// int[] collection1 = new int[8];

// GetArray(collection1);
// Console.Write($"[{String.Join(", ", collection1)}]");

// void GetArray(int[] array3)
// {
//     for(int j = 0; j < array3.Length; j++)
//     {
//         array3[j] = new Random().Next(0, 1000);
//     }
// }


// ВАРИАНТ 3 (по аналогии с решением на семинаре)

// int[] collection2 = FullfillArray(8);
// Console.Write($"[{String.Join(", ", collection2)}]");

// int[] FullfillArray(int length)
// {
//     int[] array = new int[length];
    
//     for(int x = 0; x < array.Length; x++)
//     {
//         array[x] = new Random().Next(0, 1000);
//     }

//     return array;
// }
