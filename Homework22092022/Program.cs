// ЗАДАЧА 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Вариант 1
// Console.WriteLine("Введите число N  ");
// int N = int.Parse(Console.ReadLine());

// for (int i = 1; i <= N; i++)
// {
//     Console.Write(i*i*i + " ");
// }


// Вариант 2
// Console.WriteLine("Введите число N  ");
// int N = int.Parse(Console.ReadLine());

// if (N > 1)
// {
//     for (int i = 1; i <= N; i++)
//     {
//         Console.Write($"{Math.Pow(i, 3)} ");
//     }
// }
// else
// {
//     Console.Write("Число N должно быть больше 1");
// }





// ЗАДАЧА 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Введите координату x1 для первой точки: ");
// int x1 = int.Parse(Console.ReadLine());
// Console.Write("Введите координату y1 для первой точки: ");
// int y1 = int.Parse(Console.ReadLine());
// Console.Write("Введите координату z1 для первой точки: ");
// int z1 = int.Parse(Console.ReadLine());

// Console.Write("Введите координату x2 для второй точки: ");
// int x2 = int.Parse(Console.ReadLine());
// Console.Write("Введите координату y2 для второй точки: ");
// int y2 = int.Parse(Console.ReadLine());
// Console.Write("Введите координату z2 для второй точки: ");
// int z2 = int.Parse(Console.ReadLine());

// double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
// Console.WriteLine($"Расстояние между точками в 3D пространстве = {distance:f2}");





// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Решение работает только на натуральных числах

// Console.Write("Введите любое пятизначное число: ");
// int N = int.Parse(Console.ReadLine());

// int count = 0;

// for (int i = N; i > 0; )
// {
//     i = i / 10;
//     count++;
// }

// if (count == 5)
// {
//     if((N / 10000 == N % 10) && (N / 1000 % 10 == N % 100 / 10))
//     {
//         Console.WriteLine($"Число {N} является палиндромом"); 
//     }
//     else
//     {
//         Console.WriteLine($"Число {N} не является палиндромом"); 
//     }
// }
// else
// {
//    Console.WriteLine("Число N должно быть пятизначным. Введите другое число"); 
// }

