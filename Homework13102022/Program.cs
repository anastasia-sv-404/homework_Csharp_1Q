// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1


// Console.WriteLine("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);

// if (N <= 1)
// {
//     Console.WriteLine("Число N должно быть натуральным и больше 1!");
// }
// else
// {
//     Console.WriteLine(SeriesOfNumbers(N, 1));
// }





// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Console.WriteLine("Введите число M: ");
// int M = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);

// if (M >= N)
// {
//     Console.WriteLine("Число N должно быть больше M!");
// }
// else if(M <= 0 || N <= 0)
// {
//     Console.WriteLine("Числа M и N должны быть натуральными!");
// }
// else
// {
//     Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} равна {SumFromMToN(M, N)}");
// }





// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// Console.WriteLine("Введите число m: ");
// int m = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите число n: ");
// int n = int.Parse(Console.ReadLine()!);

// if (m < 0 || n < 0)
// {
//     Console.WriteLine("Числа m и n должны быть неотрицательными!");
// }
// else
// {
//     Console.WriteLine($"Вычисление функции Аккермана для чисел {m} и {n} равно {Akkerman(m, n)}");
// }



// МЕТОДЫ с рекурсией

string SeriesOfNumbers(int max, int min)
{
    if (max == min)
    {
        return Convert.ToString(min);
    }

    return (max + " " + SeriesOfNumbers(max - 1, min));
}

int SumFromMToN(int min, int max)
{
    if (min == max)
    {
        return max;
    }

    return (min + SumFromMToN(min + 1, max));
}

int Akkerman(int m, int n) // https://ru.wikipedia.org/wiki/%D0%A4%D1%83%D0%BD%D0%BA%D1%86%D0%B8%D1%8F_%D0%90%D0%BA%D0%BA%D0%B5%D1%80%D0%BC%D0%B0%D0%BD%D0%B0
{
    if (m == 0)
    {
        return (n + 1);
    }

    if ((n == 0) && (m > 0))
    {
        return (Akkerman(m - 1, 1));
    }

    return (Akkerman(m - 1, Akkerman(m, n - 1)));
}
