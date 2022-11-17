using System;
using myLib;
//// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
void Task2()
{
    Console.Clear();
    Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
    Console.WriteLine("Введите число A");
    double A = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите число B");
    double B = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Максимальное число из двух чисел " + Math.Max(A, B));
}

////Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
void Task4()
{
    Console.Clear();
    Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
    Console.WriteLine("Введите число A");
    double A = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите число B");
    double B = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите число C");
    double C = Convert.ToDouble(Console.ReadLine());
    double max1 = Math.Max(A, B);
    Console.WriteLine("Максимальное число из трех чисел " + Math.Max(max1, C));
}

////Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
void Task6()
{
    Console.Clear();
    Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
    Console.WriteLine("Введите число для проверки четное оно или нет");
    int x = Convert.ToInt32(Console.ReadLine());
    if ((x % 2) == 0)
    {
        Console.WriteLine(x + " четное");
    }
    else
    {
        Console.WriteLine(x + " нечетное");
    }
}

////Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
void Task8()
{
    Console.Clear();
    Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
    Console.WriteLine("Введите число N");
    int N = Convert.ToInt32(Console.ReadLine());
    int i = 0;
    int x = 0;
    while (i < N - 1)
    {
        i = i + 2;
        x = x + 1;
        Console.WriteLine(x + ". " + i);
    }
    Console.WriteLine("Конец");
}

////Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
void Task10()
{
    Console.Clear();
    Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
    Console.Write("Вводим трехзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (99 < number && 1000 > number)
    {
        string str = Convert.ToString(number);
        Console.WriteLine($"вторая цифра этого числа {str[1]}");
    }
    else Console.Write("НЕ то число");
}

////Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void Task13()
{
    Console.Clear();
    Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
    Console.Write("Вводим число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (99 < number)
    {
        string str = Convert.ToString(number);
        Console.WriteLine($"третья цифра этого числа {str[2]}");
    }
    else Console.Write("НЕ то число");
}

////Задача 15 Версия 2: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void Task15()
{
    Console.Clear();
    Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным..");
    Console.Write("Введите номер дня недели: ");
    int x = Convert.ToInt32(Console.ReadLine());
    while (x >= 0)
    {
        if (8 > x)
        {
            string[] day = new string[8] { "0 день?", "Будний день", "Будний день", "Будний день", "Будний день", "Будний день", "Выходной", "Выходной" };
            Console.WriteLine(day[x]);
            break;
        }
        else
        {
            Console.WriteLine("В неделе 7 дней");
            x = Convert.ToInt32(Console.ReadLine()); // продолжаем пока не нажмем 1-7
        }
    }
}

//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void Task19()
{
    int InputInt(string? value)
    {
        int number = 0;
        while (!int.TryParse(value, out number))
        {
            Console.Write("Не подходит к требованиЮ введите число: ");
            value = Console.ReadLine();
        }
        return number;
    }
    void Palindrome(int first, int last, int x1, int num)
    {
        int i = 1;
        while (x1 > i)
        {
            first = (int)((num / Math.Pow(10, (x1 - i))) % 10);
            last = num % 10;
            Console.Write($"{first}");
            Console.WriteLine($"{last}");
            x1 = x1 - 1;
            i++;
            num = num / 10;
            if (first != last)
            {
                Console.WriteLine("не палиндром");
                return;
            }
        }
        Console.WriteLine("Палиндром");
    }
    Console.WriteLine($"Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом");
    Console.WriteLine("Введите пятизначное число: ");
    int num = InputInt(Console.ReadLine());
    int first = 0;
    int last = 0;
    string x = Convert.ToString(num);
    int x1 = x.Length;
    if (num > 9999 && 100000 > num)
    {
        Palindrome(first, last, x1, num);
    }
    else Console.WriteLine($"не подходит по требованиям");
}

////// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
void Task21()
{
    void Coordinate(ref double x, ref double y, ref double z)
    {
        string? line;
        while ((line = Console.ReadLine()) == null) line = Console.ReadLine();
        string[] splitString = line.Split(' ');
        x = Convert.ToDouble(splitString[0]);
        y = Convert.ToDouble(splitString[1]);
        z = Convert.ToDouble(splitString[2]);
    }
    Console.Clear();
    Console.WriteLine("Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
    Console.WriteLine("Введите координаты точки A x1 y1 z1 через пробел");
    Double x1 = 0, y1 = 0, z1 = 0;
    Coordinate(ref x1, ref y1, ref z1);
    Console.WriteLine("Введите координаты1 точки B x2 y2 z2 через пробел");
    Double x2 = 0, y2 = 0, z2 = 0;
    Coordinate(ref x2, ref y2, ref z2);
    double result = Math.Round(Math.Pow(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) * 1.0, 0.5), 2);
    Console.WriteLine($"Расстояние между двумя точками в 3D пространстве: {result}");
}

////Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Task23()
{
    int InputInt(string? value)
    {
        int number = 0;
        { }
        while (!int.TryParse(value, out number))
        {
            Console.Write("Не подходит к требованию введите число: ");
            value = Console.ReadLine();
        }
        return number;
    }
    Console.Clear();
    Console.WriteLine("Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
    Console.Write("Введите число N ");
    int number = InputInt(Console.ReadLine());
    if (number > 0)
    {
        for (int i = 1; i < number; i++) Console.WriteLine($"{Math.Pow(i, 3)}, ");
        Console.WriteLine($"{Math.Pow(number, 3)}");
    }
    else Console.WriteLine("Не подходит");
}

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Console.WriteLine($"Задача 25. Возведение числа A в натуральную степень B");
// int numberA = 1;
// int numberB = 1;
// int InputInt(string? value)                                               // Проверка что ввели целое число;
// {
//     int number = 0;
//     while (!int.TryParse(value, out number))
//     {
//         Console.Write("Не подходит к требованию введите число: ");
//         value = Console.ReadLine();
//     }
//     return number;
// }
// void Number(ref int numberA, ref int numberB)                             // Ввод чисел A и B и проверяем натуральное ли число B
// {
//     Console.Write("Введите число A: ");
//     numberA = InputInt(Console.ReadLine());
//     Console.Write("Введите число B: ");
//     numberB = InputInt(Console.ReadLine());
//     if (numberB < 0)
//     {
//         Console.Write("Введите число B: ");
//         numberB = InputInt(Console.ReadLine());
//     }
// }

// int Exponentiation(int numberA, int numberB)                              // Возводим число A в степень числа B или можно просто в Math.Pow
// {
//     int result = 1;
//     for (int i = 1; i <= numberB; i++)
//     {
//         result = result * numberA;
//     }
//     return result;
// }

// Number(ref numberA, ref numberB);                                         // Получаем числа
// Console.WriteLine($"Ответ: {Exponentiation(numberA, numberB)}");          // и ответ

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// int InputInt(string? value)                                               // Проверка что ввели целое число;
// {
//     int number = 0;
//     while (!int.TryParse(value, out number))
//     {
//         Console.Write("Не подходит к требованию введите число: ");
//         value = Console.ReadLine();
//     }
//     return number;
// }
// Console.WriteLine($"Задача 27. Выдаёт сумму цифр в числе");
// Console.Write("Введите число N: ");
// int numberN = InputInt(Console.ReadLine());

// int SumNumber(int numberN)
// {
//     int counter = Convert.ToString(numberN).Length;                         // узнаем количество цифр в числе
//     int advance = 0;
//     int result = 0;
//     for (int i = 0; i < counter; i++)
//     {
//         advance = numberN - numberN % 10;                                   // обнуляем последнею цифру в числе
//         result = result + (numberN - advance);                              // сумма последних цифр, поэтому будет работать и с отрицательными числами
//         numberN = numberN / 10;                                             // уменьшаем число на один знак
//     }
//     return result;                                                          // конечная сумма всех чисел
// }

// Console.WriteLine($"Сумма цифр в числе: {SumNumber(numberN)}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// void Massive()
// {   Console.WriteLine($"Задача 29. Ряд чисел преобразует в массив");
//     Console.Write("Введите ряд чисел, разделенных запятой с пробелом: ");
//     string? number = Console.ReadLine();                                  // Прописываем строку 
//     string[] num = number.Split(',');                                     // Делим строку на массив
//     int i = num.Length;                                                   
//     if (i < 9 && i > 1)                                                   // проверяем массив на количество элементов
//     {
//         Console.WriteLine($"[{String.Join(",", num)}]");
//     }
//     else
//     {
//         Console.WriteLine($"Вы ввели не верный массив");
//     }
// }

// Massive();


//// Задача 41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
void Greater()
{
    Console.WriteLine($"Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
    Console.WriteLine("Введите ряд чисел, разделенных запятой с пробелом  пример: 0, 7, 8, -2, -2");
    string? num;
    int greater = 0;
    while ((num = Console.ReadLine()) == null)
    {
        num = Console.ReadLine();
    }
    string[] number = num.Split(',');
    int[] ints = Array.ConvertAll(number, int.Parse);
    for (int i = 0; i < ints.Length; i++)
    {
        if (ints[i] > 0)
        {
            greater++;
        }
    }
    Console.WriteLine($"В массиве [{String.Join(", ", ints)}] num>0 -> {greater}");
}

//// Задача 43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
void Line(ref double b, ref double k)
{
    string? line;
    while ((line = Console.ReadLine()) == null)
    {
        line = Console.ReadLine();
    }
    string[] splitString = line.Split(' ');
    b = Convert.ToDouble(splitString[0]);
    k = Convert.ToDouble(splitString[1]);
}

void CrossPoint()
{
    double k1 = 0, k2 = 0, b1 = 0, b2 = 0;
    Console.WriteLine($"Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
    Console.WriteLine($"Пример:значения k1 = 5, b1 = 2, k2 = 9, b2 = 4   точка пересечения -> (-0,5; -0,5");
    Console.WriteLine($"Введите значения k1 и b1 заданной прямой  y = k1 * x + b1 череза пробел ");
    Line(ref k1, ref b1);
    Console.WriteLine($"Введите значения k2 и b2 заданной прямой  y = k2 * x + b2 череза пробел ");
    Line(ref k2, ref b2);
    if (b1 == b2 && k1 != k2)
    {
        Console.Write($"Точка пересечения заданных прямых: (0; {b1})");
    }
    else if (b1 == b2 && k1 == k2)
    {
        Console.Write($"Вы ввели одинаковые значения, прямые совпадают (бесконечное множество точек пересечения).");
    }
    else if (k1 == k2)
    {
        Console.Write($"Прямые параллельны.");
    }
    else
    {
        double x = (b1 - b2) / (k2 - k1);
        double y = (k2 * b1 - k1 * b2) / (k2 - k1);
        Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
    }
}

////Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void Task47()
{
    double[,] GetTwoDimensionalArray()
    {
        Console.Clear();
        Console.WriteLine($"Задача 47. Задайте двумерный массив размером mxn, заполненный случайными вещественными числами.");
        Console.WriteLine($"Введите через пробел размеры двумерного массива и диапазон чисел, пример: 5 5 1 100 ");
        string? line;
        while ((line = Console.ReadLine()) == null) line = Console.ReadLine();
        string[] values = line.Split(' ');
        int row = Convert.ToInt32(values[0]);
        int column = Convert.ToInt32(values[1]);
        int M = Convert.ToInt32(values[2]);
        int N = Convert.ToInt32(values[3]);
        double[,] massive = function.getRandomTwoDimensionalArrayDouble(row, column, M, N);
        return massive;
    }

    void PrintArray(double[,] massive)
    {
        for (int f = 0; f < massive.GetLength(0); f++)
        {
            Console.WriteLine();
            for (int j = 0; j < massive.GetLength(1); j++) Console.Write(string.Format("{0,6} |", massive[f, j]));
            Console.WriteLine();
        }
    }

    double[,] twoDimensionalArray = GetTwoDimensionalArray();
    PrintArray(twoDimensionalArray);
}

////Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
////возвращает значение этого элемента или же указание, что такого элемента нет.
void Task50()
{
    int[,] array = function.getRandomTwoDimensionalArrayInt(10, 10, 1, 100);

    Console.WriteLine("Задача 50. Программа которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
    Console.WriteLine("Введите через пробел координаты элемента");
    string? line;
    while ((line = Console.ReadLine()) == null) line = Console.ReadLine();
    string[] values = line.Split(' ');
    int row = Convert.ToInt32(values[0]);
    int column = Convert.ToInt32(values[1]);
    if (row > 9 || column > 9 || row < 0 || column < 0) Console.WriteLine("Такого элемента нет");
    else Console.WriteLine($"Значение под строкой {row} и столбцом {column} -> {array[row, column]}");
    Console.WriteLine("Показать массив, да нажмите стрелочку ↑ вверх и нет ↓ вниз");
    KeyPressed(Console.ReadKey());
    void KeyPressed(ConsoleKeyInfo key)
    {
        switch (key.Key)
        {
            case ConsoleKey.UpArrow:
                PrintArray(array);
                break;
            case ConsoleKey.DownArrow:
                Console.WriteLine(" Конец ");
                break;
        }
        void PrintArray(int[,] massive)
        {
            for (int f = 0; f < 10; f++)
            {
                Console.WriteLine();
                for (int j = 0; j < 10; j++) Console.Write(string.Format("{0,3} |", massive[f, j]));
            }
        }

    }
}

////Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
///Например, задан массив:
///1 4 7 2
///5 9 2 3
///8 4 2 4
////Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void Task52()
{   
    Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
    Console.WriteLine("Введите через пробел размеры двумерного массива и диапазон чисел, пример: 5 5 1 100 ");
    string? line;
    while ((line = Console.ReadLine()) == null) line = Console.ReadLine();
    string[] values = line.Split(' ');
    int row = Convert.ToInt32(values[0]);
    int column = Convert.ToInt32(values[1]);
    int M = Convert.ToInt32(values[2]);
    int N = Convert.ToInt32(values[3]);
    int[,] array = function.getRandomTwoDimensionalArrayInt(row, column, M, N);


    for (int i = 0; i < row; i++)
    {
        double sum = 0;
        for (int j = 0; j < column; j++) sum = sum + Convert.ToDouble(array[j, i]);
        Console.Write($" {sum / row} |");
    }
    Console.WriteLine();

    Console.WriteLine("Показать массив, да нажмите стрелочку ↑ вверх и нет ↓ вниз");
    KeyPressed(Console.ReadKey());
    void KeyPressed(ConsoleKeyInfo key)
    {
        switch (key.Key)
        {
            case ConsoleKey.UpArrow:
                PrintArray(array);
                break;
            case ConsoleKey.DownArrow:
                Console.WriteLine(" Конец ");
                break;
        }
    }
    void PrintArray(int[,] massive)
    {
        for (int f = 0; f < row; f++)
        {
            Console.WriteLine();
            for (int j = 0; j < row; j++) Console.Write(string.Format("{0,4} |", massive[f, j]));
        }
    }

}





Console.Clear();
Console.Write($"Введите номер задания: ");
int task = Convert.ToInt32(Console.ReadLine());
switch (task)
{
    case 2:
        Console.Clear();
        Task2();
        break;
    case 4:
        Console.Clear();
        Task4();
        break;
    case 6:
        Console.Clear();
        Task6();
        break;
    case 8:
        Console.Clear();
        Task8();
        break;
    case 10:
        Console.Clear();
        Task10();
        break;
    case 13:
        Console.Clear();
        Task13();
        break;
    case 15:
        Console.Clear();
        Task15();
        break;
    case 19:
        Console.Clear();
        Task19();
        break;
    case 21:
        Console.Clear();
        Task21();
        break;
    case 23:
        Console.Clear();
        Task23();
        break;
    case 41:
        Console.Clear();
        Greater();
        break;
    case 43:
        Console.Clear();
        CrossPoint();
        break;
    case 47:
        Console.Clear();
        Task47();
        break;
    case 50:
        Console.Clear();
        Task50();
        break;
    case 52:
        Console.Clear();
        Task52();
        break;
}
