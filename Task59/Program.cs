// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
int[,] CreateMatrixRndInt(int row, int columns, int min, int max)
{
    var matrix = new int[row, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
return matrix;
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
    {
    if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 4},");
    else Console.Write($"{matrix[i, j], 4}");
    }
    Console.WriteLine(" ]");
    }
}

int[] FindMin(int[,] matrix)
{
    int min = matrix[0, 0];
    int minRow = 0;
    int minColumn = 0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                minRow = i;
                minColumn = j;
            }
        }
    }
    return new int[] { min, minRow, minColumn };
}

void PrintArray(int[] array) // печатаем одномерный массив
{
    for (int i = 0; i < array.Length; i++) 
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, "); 
        else Console.Write($"{array[i]} ");
    }
}

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2D);

int[] min = FindMin(array2D);
PrintArray(min);