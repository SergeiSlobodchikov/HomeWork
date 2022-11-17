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
                result[i, j] = Convert.ToDouble(new Random().Next(ofX, toY+1)) / 100;
            }
           
        } 
        return result;
    }

    
}
