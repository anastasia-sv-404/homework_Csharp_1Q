/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

/*
Console.WriteLine("Введите первое число  ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число  ");
int number2 = int.Parse(Console.ReadLine());


// Вариант решения 1

/*if (number2 > number1)
{
    Console.WriteLine("Число " + number2 + " больше числа " + number1);
}
else
{
    Console.WriteLine("Число " + number1 + " больше числа " + number2);
}*/


// Вариант решения 2 - с  дополнением

/*if (number2 > number1) Console.WriteLine("Число " + number2 + " больше числа " + number1);
    else if (number2 == number1) Console.WriteLine("Числа равны");
        else if (number1 > number2) Console.WriteLine("Число " + number1 + " больше числа " + number2);
*/





/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

/*
Console.WriteLine("Введите первое число ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число ");
int x3 = int.Parse(Console.ReadLine());

int max = x1;

if (x2 > max) max = x2;
if (x3 > max) max = x3;

Console.Write("Максимальное число равно ");
Console.Write(max);
*/





/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

/*
Console.WriteLine("Введите число  ");
int a = int.Parse(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine($"Число {a} является четным");
}
else
{
    Console.WriteLine($"Число {a} является нечетным");
}
*/





/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

/*
Console.WriteLine("Введите число  ");
int N = int.Parse(Console.ReadLine());

int i = 1;*/

// Вариант написания кода 1

/*if (N <= 0) 
{
    Console.WriteLine("Число N является отрицательным или равно 0, введите другое число");
}
else
{
    if (N == 1)
        {
            Console.WriteLine("Чтобы задать интервал, число N должно быть больше 1");
        }
    else
    {
        while (i <= N)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        i++;
        }
    }
}*/

// Вариант написания кода 2
/*Console.WriteLine("Введите число  ");
int N = int.Parse(Console.ReadLine());

int i = 1;

if (N <= 0) Console.WriteLine("Число N является отрицательным или равно 0, введите другое число");
    else if (N == 1) Console.WriteLine("Чтобы задать интервал, число N должно быть больше 1");
      else if (N > 1)
        {
            while (i <= N)
            {
             if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
                i++;
             }
        }
*/