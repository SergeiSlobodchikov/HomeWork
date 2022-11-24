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
        if (ints[i] > 0) greater++;
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
        double y = (k1 * x + b1);
        Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
    }
}

////Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void Task47()
{
    double[,] GetTwoDimensionalArray()  //// Указываем размеры и диапазон массива 
    {
        Console.Clear();
        Console.WriteLine($"Задача 47. Задайте двумерный массив размером mxn, заполненный случайными вещественными числами.\n" +
            "Введите через пробел размеры двумерного массива и диапазон чисел, пример: 5 5 1 100 ");
        string? line;
        while ((line = Console.ReadLine()) == null) line = Console.ReadLine();
        string[] values = line.Split(' ');
        int row = Convert.ToInt32(values[0]);
        int column = Convert.ToInt32(values[1]);
        int M = Convert.ToInt32(values[2]);
        int N = Convert.ToInt32(values[3]);
        double[,] massive = function.getRandomTwoDimensionalArrayDouble(row, column, M, N);  //// Создаем массив из библиотеки классов myLib
        return massive;
    }

    void PrintArray(double[,] massive)  ////Печатает массив в консоль
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
    int[,] array = function.getRandomTwoDimensionalArrayInt(10, 10, 1, 100); //// Создаем массив из библиотеки классов myLib 

    Console.WriteLine("Задача 50. Программа которая на вход принимает позиции элемента в двумерном массиве, \n" +
        "и возвращает значение этого элемента или же указание, что такого элемента нет.\n" +
        "Задан массив 10х10, введите через пробел координаты элемента X и Y ");
    string? line;
    while ((line = Console.ReadLine()) == null) line = Console.ReadLine();
    string[] values = line.Split(' ');
    int row = Convert.ToInt32(values[0]);
    int column = Convert.ToInt32(values[1]);

    if (row > array.GetLength(0) - 1 || column > array.GetLength(1) - 1 || row < 0 || column < 0) Console.WriteLine("Такого элемента нет");   ////проверка позиции
    else Console.WriteLine($"Значение под строкой {row} и столбцом {column} -> {array[row, column]}");
    Console.WriteLine("Показать массив, да нажмите стрелочку ↑ вверх и нет ↓ вниз");
    KeyPressed(Console.ReadKey());

    void KeyPressed(ConsoleKeyInfo key) //// функция для нажатия стрелок
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

    void PrintArray(int[,] massive)   ////Печатает массив в консоль
    {
        for (int f = 0; f < 10; f++)
        {
            Console.WriteLine();
            for (int j = 0; j < 10; j++) Console.Write(string.Format("{0,3} |", massive[f, j]));
        }
    }

}

////Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
///Например, задан массив:
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
    int[,] array = function.getRandomTwoDimensionalArrayInt(row, column, M, N);  //// Создаем массив из библиотеки классов myLib          

    for (int i = 0; i < column; i++)
    {
        double sum = 0;
        for (int j = 0; j < row; j++) sum = sum + Convert.ToDouble(array[j, i]); //// сумма столбца
        Console.Write(string.Format("{0,4:0.##} |", sum / row));
    }
    Console.WriteLine();

    Console.WriteLine("Показать массив, да нажмите стрелочку ↑ вверх и нет ↓ вниз");
    KeyPressed(Console.ReadKey());

    void KeyPressed(ConsoleKeyInfo key) //// действия с клавиатурой
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
    void PrintArray(int[,] massive) ////Печатает массив в консоль
    {
        for (int f = 0; f < row; f++)
        {
            Console.WriteLine();
            for (int j = 0; j < column; j++) Console.Write(string.Format("{0,4} |", massive[f, j]));
        }
    }

}
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
void Task54()
{
    int row = 0, column = 0, x = 1, y = 100;
    Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.\n" +
                    "Укажите размер массива количество строк и столбцов");
    function.TwoNumbersFromString(ref row, ref column);
    int[,] array = function.getRandomTwoDimensionalArrayInt(row, column, x, y);
    function.PrintIntTwoDimArray(array);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            if (j < array.GetLength(1) - 1 && array[i, j] < array[i, j + 1])
            {
                if (array[i, j + 1] > array[i, 0])
                {
                    int value = array[i, 0];
                    array[i, 0] = array[i, j + 1];
                    array[i, j + 1] = value;
                }
                else
                {
                    int value = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = value;
                }
                j = 0;
            }
        }
    }
    Console.WriteLine();
    function.Color("cyan");
    function.PrintIntTwoDimArray(array);
    Console.ResetColor();
}

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void Task56()
{
    int[] SumOfLines(int[,] twoArray)
    {
        int[] arrayOneDim = new int[twoArray.GetLength(0)];
        for (int i = 0; i < twoArray.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < twoArray.GetLength(1); j++) sum = sum + twoArray[i, j];
            arrayOneDim[i] = sum;
        }
        Console.WriteLine();
        return arrayOneDim;
    }

    void StringPointer(int[] array)
    {
        int number = array[0], counter = 0;
        function.Color("green");
        Console.Write($"Сумма строк:");
        for (int i = 0; i < array.Length; i++)
        {
            if (number > array[i])
            {
                number = array[i];
                counter = i;
            }
            Console.Write($" ({i}) {array[i]}, ");
        }
        Console.WriteLine();
        function.Color("cyan");
        Console.WriteLine($"Наименьшая строка {counter}  ");
        Console.ResetColor();
    }
    Console.WriteLine($"Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.\n"+
    "Укажите размер массива количество строк и столбцов");
    int row = 0, column = 0;
    function.TwoNumbersFromString(ref row, ref column);
    int[,] arrayTwoDim = function.getRandomTwoDimensionalArrayInt(row, column, 1, 10);
    function.PrintIntTwoDimArray(arrayTwoDim);
    int[] arrayOneDim = SumOfLines(arrayTwoDim);
    StringPointer(arrayOneDim);

}

////Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void Task58()
{
    void MatrixMultiplication(int[,] arrayOne, int[,] arrayTwo)
    {
        int[,] matrix = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];
        for (int i = 0; i < arrayOne.GetLength(0); i++)
        {
            for (int j = 0; j < arrayTwo.GetLength(1); j++)
            {
                for (int z = 0; z < arrayTwo.GetLength(0); z++)
                {
                    matrix[i, j] += arrayOne[i, z] * arrayTwo[z, j];
                }
            }
        }
        function.PrintIntTwoDimArray(matrix);
    }

    Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.\n" +
    "Укажите размер массива количество строк и столбцов");
    int row = 0, column = 0;
    function.TwoNumbersFromString(ref row, ref column);
    int[,] arrayTwoDimOne = function.getRandomTwoDimensionalArrayInt(row, column, 1, 10);
    function.PrintIntTwoDimArray(arrayTwoDimOne);
    Console.WriteLine("Матрица А");
    Console.WriteLine();
    function.TwoNumbersFromString(ref row, ref column);
    int[,] arrayTwoDimTwo = function.getRandomTwoDimensionalArrayInt(row, column, 1, 10);
    function.PrintIntTwoDimArray(arrayTwoDimTwo);
    Console.WriteLine("Матрица B");
    Console.WriteLine();
    function.Color("cyan");
    if (arrayTwoDimOne.GetLength(1) != arrayTwoDimTwo.GetLength(0)) Console.WriteLine("Количество столбцов первой матрицы и строк второй должны быть одинаковыми");
    else
    {   
        MatrixMultiplication(arrayTwoDimOne, arrayTwoDimTwo);
        Console.WriteLine("Матрица C=A*B");
    }
    Console.ResetColor();
}
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
void Task60()
{

    void Random(int[,,] array, int i, int j, int k)
    {
        for (int x = 0; x < array.GetLength(0); x++)
        {
            for (int y = 0; y < array.GetLength(1); y++)
            {
                for (int z = 0; z < array.GetLength(2); z++)
                {
                    if (array[i, j, k] == array[x, y, z] && i == x && j == y && k == z)
                    {
                        array[i, j, k] = array[x, y, z];
                    }
                    else if (array[i, j, k] == array[x, y, z])
                    {
                        array[i, j, k] = new Random().Next(10, 100);
                        x = 0; y = 0; z = 0;
                    }
                }
            }
        }
    }

    int[,,] ThreeDimensionalArray = new int[2, 2, 2];

    for (int i = 0; i < ThreeDimensionalArray.GetLength(0); i++)
    {
        for (int j = 0; j < ThreeDimensionalArray.GetLength(1); j++)
        {
            for (int k = 0; k < ThreeDimensionalArray.GetLength(2); k++)
            {
                ThreeDimensionalArray[i, j, k] = new Random().Next(10, 100);
                Random(ThreeDimensionalArray, i, j, k);

            }
        }
    }

    Console.WriteLine($"Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу\n" +
     "которая будет построчно выводить массив, добавляя индексы каждого элемента.");
    for (int i = 0; i < ThreeDimensionalArray.GetLength(2); i++)
    {
        for (int j = 0; j < ThreeDimensionalArray.GetLength(1); j++)
        {
            for (int k = 0; k < ThreeDimensionalArray.GetLength(0); k++)
            {

                Console.WriteLine($"{ThreeDimensionalArray[k, j, i]} ({k},{j},{i}) {ThreeDimensionalArray[k, j + 1, i]} ({k},{j + 1},{i})");
            }
            j++;
        }

    }

}

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
void Task62()
{
    int row = 0, column = 0;
    Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.\n" +
                    "Укажите размер массива количество строк и столбцов");
    function.TwoNumbersFromString(ref row, ref column);

    int[,] array = new int[row, column];
    int numRow = array.GetLength(0), numColumn = array.GetLength(1);
    int upLeftCorner = 0, downRightCorner = 0, downLeftCorner = 0, upRightCorner = 0;
    int counter = 1;
    int i = 0;
    int j = 0;

    while (counter <= numRow * numColumn)
    {
        array[i, j] = counter;
        if (i == upLeftCorner && j < numColumn - upRightCorner - 1) j++;
        else if (j == numColumn - upRightCorner - 1 && i < numRow - downRightCorner - 1) i++;
        else if (i == numRow - downRightCorner - 1 && j > downLeftCorner) j--;
        else i--;

        if ((i == upLeftCorner + 1) && (j == downLeftCorner) && (downLeftCorner != numColumn - upRightCorner - 1))
        {
            upLeftCorner++;
            downRightCorner++;
            downLeftCorner++;
            upRightCorner++;
        }
        counter++;
    }

    function.PrintIntTwoDimArray(array);
}
//     Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
void Task64()
{
function.Color("yellow");
Console.WriteLine(" Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.\n"+
                    "Задайте значения N. Программа выведет все натуральные числа от N до 1.");
Console.WriteLine();

function.Color("green");
Console.Write("Введите число N: ");
int N = function.Number();

void Recursion(int number)
{   Console.Write($"{number} ");
    if(number==1) return;
    else number--;
    Recursion(number);
}

Recursion(N);
Console.ResetColor();
}

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
void Task66()
{
function.Color("yellow");
Console.WriteLine(" Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.\n" +
                    "Задайте значения M и N. Программа выведет сумму всех натуральных чисел от M до N.");
Console.WriteLine();

function.Color("green");
Console.Write("Введите число M: ");
int M = function.Number();

function.Color("green");
Console.Write("Введите число N: ");
int N = function.Number();
int counter = 0, difference = 0, sum = 0;

if (M > N) difference = M - N;
else difference = N - M;

void Sum(int number1, int number2, ref int sum)
{
    if (counter == difference + 1) return;
    else if (number1 < number2)
    {
        sum = sum + number1 + counter;
    }
    else if (number1 > number2)
    {
        sum = sum + number1 - counter;
    }
    counter++;
    Sum(number1, number2, ref sum);
}

Sum(M, N, ref sum);
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {sum}");
Console.ResetColor();
}
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
void Task68()
{
function.Color("yellow");
Console.WriteLine(" Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.\n" +
                    "Задайте значения M и N. Программа выведет вычисления функции Аккермана.");
Console.WriteLine();

function.Color("green");
Console.Write("Введите число M рекомендация не более 3: ");
int m = function.NumberZero();

function.Color("green");
Console.Write("Введите число N рекомендация не более 5: ");
int n = function.NumberZero();

if (m > 3)
{
    m = 4;
    n = 0;
    Console.WriteLine("число M: 4\n" +
   "число N: 0");
}
else if(n>5)
{
n = 5;
    Console.WriteLine($"число M: {m}\n" +
   "число N: 5");
}

static int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else
    {
        if (m != 0 && n == 0) return Akkerman(m - 1, 1);
        else return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

int akkerman = Akkerman(m, n);
Console.WriteLine($"A(m,n): {akkerman}");
Console.ResetColor();
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
    case 54:
        Console.Clear();
        Task54();
        break;
    case 56:
        Console.Clear();
        Task56();
        break;
    case 58:
        Console.Clear();
        Task58();
        break;
    case 60:
        Console.Clear();
        Task60();
        break;
    case 62:
        Console.Clear();
        Task62();
        break;
    case 64:
        Console.Clear();
        Task64();
        break;
    case 66:
        Console.Clear();
        Task66();
        break;
    case 68:
        Console.Clear();
        Task68();
        break;
}
