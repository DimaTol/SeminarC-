// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int SumElememts (int [,] matrix)
{
int sum = default;

 for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

          if (i == j) sum += matrix [i,j];
        }
    }
    return sum;
}


int SumElememts2 (int [,] matrix)
{
int sum = default;
int demention = 0;
if (matrix.GetLength (0) > matrix.GetLength(1)) demention = 1;
 for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix [i,i];
    }
   return sum;
}


int [,] array2D = CreateMatrixRndInt (3,3,1,10);
PrintMatrix (array2D);

int sumElememts = SumElememts2 (array2D);
Console.WriteLine(sumElememts);