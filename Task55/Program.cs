// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

void ExchangeRowColumns (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
    {
        int temp = matrix [i,j];
        matrix [i, j] = matrix [j,i];
        matrix [j,i] = temp;
    }
    }
}

bool Quatro (int [,] arr)
{
   {
    return (arr.GetLength (0) == arr.GetLength(1));
   }
}

int[,] array2D = CreateMatrixRndInt(4, 5, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();

bool quatro = Quatro (array2D);
if (quatro) 
{
ExchangeRowColumns (array2D);
PrintMatrix (array2D);
}
else Console.WriteLine("Замена невозможна");

