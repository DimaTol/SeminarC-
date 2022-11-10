// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4},");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}

int[,] Multiplication2dArray(int[,] array1, int[,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array1[i, j] = array1[i, j] * array2[i, j];
        }
    }
    return array1;
}


int[,] array2d1 = CreateMatrixRndInt(2, 2, 1, 10);
PrintMatrix(array2d1);
Console.WriteLine("и");
int[,] array2d2 = CreateMatrixRndInt(2, 2, 1, 10);
PrintMatrix(array2d2);
Console.WriteLine("=");
int [,] multArray = Multiplication2dArray (array2d1,array2d2);
PrintMatrix (multArray);