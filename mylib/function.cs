namespace myLib;

public class function
{
    // создание целочисленного двумерного массива длиной с числами от x до y
    public static int[,] getRandomTwoDimensionalArrayInt(int row, int column, int x, int y)
    {
        int[,] result = new int[row, column];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++) result[i, j] = new Random().Next(x, y + 1);
        }
        return result;
    }
    // Создание вещественного двумерного массива с числами от x до y
    public static double[,] getRandomTwoDimensionalArrayDouble(int row, int column, int x, int y)
    {
        int ofX = x * 100;
        int toY = y * 100;
        double[,] result = new double[row, column];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                result[i, j] = Convert.ToDouble(new Random().Next(ofX, toY + 1)) / 100;
            }

        }
        return result;
    }


    public static void TwoNumbersFromString(ref int num1, ref int num2)
    {
        Console.WriteLine("Укажите первое число и второе через пробел \n" +
                        "пример: 10 22");
        string? line;
        while ((line = Console.ReadLine()) == null) line = Console.ReadLine();
        string[] values = line.Split(' ');
        int numericValue;
        for (int i = 0; i < values.Length; i++)
        {
            bool isNumber = int.TryParse(values[i], out numericValue);
            if (!isNumber)
            {
                Console.WriteLine("Вы ввели не правильно строку");
                TwoNumbersFromString(ref num1, ref num2);
                return;
            }
        }
        num1 = Convert.ToInt32(values[0]);
        num2 = Convert.ToInt32(values[1]);
    }

    
    public static void  PrintIntTwoDimArray(int[,] array)
    {
    for (int x = 0; x < array.GetLength(0); x++)
    {   Console.WriteLine("");
        for (int y = 0; y < array.GetLength(1); y++)
        {
            Console.Write(string.Format("{0,4:00} |", array[x, y]));
        }
        Console.WriteLine("");
    }}

}