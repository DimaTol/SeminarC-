// Задача 54: 
//1. Задайте двумерный массив. 
//2. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
    Console.WriteLine("]");
    }
}

// void SortingArray(int[,] sortingArray)
// {
//     int temp;
//     int max;
//     for (int i = 0; i < sortingArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < sortingArray.GetLength(1) - 1; j++)
//         {
//             max = j;

//             for (int k = j; k < sortingArray.GetLength(1); k++)
//             {
//                 if (sortingArray[i, k] > sortingArray[i, max])
//                 {
//                     max = k;
//                 }
//             }
//             if (max != j)
//             {
//                 temp = sortingArray[i, j];
//                 sortingArray[i, j] = sortingArray[i, max];
//                 sortingArray[i, max] = temp;
//             }
//         }
//     }
// }


int SortingArr(int[,] sortingArray)
{
    int array = 0;
    for (int i = 0; i < sortingArray.GetLength(0); i++)
    {

        for (int j = 0; j < sortingArray.GetLength(1); j++)
        {

            for (int k = 0; k < sortingArray.GetLength(1) - 1; k++)
            {
                if (sortingArray[i, k] < sortingArray[i, k+1])
                {
                    int temp = sortingArray[i, k];
                    sortingArray[i, k] = sortingArray[i, k+1];
                    sortingArray[i, k+1] = temp;
                }
            }
        }

    }
    return array;
}


int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();

// SortingArray (array2d);
int sort = SortingArr (array2d);
PrintMatrix(array2d);