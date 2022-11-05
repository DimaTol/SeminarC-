// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new double[rows, columns];
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

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}


void ArefArray(double[,] arr)
{
    double aref = 0;
    for (int b = 0; b < arr.GetLength(1); b++)
    {
        double sum = 0;
        for (int a = 0; a < arr.GetLength(0); a++)
        {
            sum += arr[a,b];
            
        }
        aref = sum / arr.GetLength(0);
        Console.WriteLine ($"Среднее арефметическое значений из столбца {b+1} равно: {aref}");
    }
    
}

double[,] array2D = CreateMatrixRndInt(2, 2, 1, 10);
PrintMatrix(array2D);
ArefArray (array2D);