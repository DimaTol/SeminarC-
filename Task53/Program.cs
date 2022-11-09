// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
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

void ExchangeRow (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp = matrix [0,i];
        matrix[0, i] = matrix [matrix.GetLength(0) - 1, i];
        matrix [matrix.GetLength(0) - 1, i] = temp;
    }
}

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2D);

Console.WriteLine();
ExchangeRow (array2D);
PrintMatrix (array2D);
