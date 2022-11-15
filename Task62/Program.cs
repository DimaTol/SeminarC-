// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillArray(int rows, int columns)
{
    var arr = new int[rows, columns];
    int lenghtRows = arr.GetLength(0);
    int lenghtColums = arr.GetLength(1);
    int count = 1;

    for (int i = 0; i < arr.GetLength(0)/2; i++)
    {
        lenghtColums--;
        lenghtRows--;
        for (int j = i; j < lenghtColums; j++)
        {
            arr[i, j] = count;
            count++;
        }
        for (int k = i; k < lenghtRows; k++)
        {
            arr[k, lenghtRows] = count;
            count++;
        }
        
        for (int m = lenghtColums; m > i; m--)
        {
            arr[lenghtColums, m] = count;
            count++;
        }

        for (int n = lenghtRows; n > i; n--)
        {
            arr[n, i] = count;
            count++;
        }
       
    }

    return arr;
}

void PrintArray(int[,] matrix)
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


int[,] array2d = FillArray(4, 4);
PrintArray(array2d);
