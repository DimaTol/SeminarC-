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

int[,] Multiplication2dArray(int[,] array1, int[,] array2, int[,] arrayFinal)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            arrayFinal[i, j] = default;
            for (int k = 0; k < array2.GetLength(1); k++)
            {
                arrayFinal[i, j] = arrayFinal[i, j] + (array1[i, k] * array2[k, j]);
            }
        }
    }
    return arrayFinal;
}

bool Quatro(int[,] arr1, int[,] arr2)
{
    return (arr1.GetLength(0) == arr2.GetLength(1));
}

int[,] array2d1 = CreateMatrixRndInt(4, 4, 0, 4);
PrintMatrix(array2d1);
Console.WriteLine("и");
int[,] array2d2 = CreateMatrixRndInt(4, 4, 0, 4);
PrintMatrix(array2d2);
int[,] arrayFin = new int [4,4];

bool quatro = Quatro(array2d1, array2d2);
Console.WriteLine();
if (quatro)
{
    Console.WriteLine("=");
    int[,] multArray = Multiplication2dArray(array2d1, array2d2, arrayFin);
    PrintMatrix(multArray);
}
else Console.WriteLine("Произведение данных матриц невозможно");
