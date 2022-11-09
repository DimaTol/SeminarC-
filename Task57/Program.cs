// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
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

int [] NewArray(int[,] array2D) //переводим двумерный массив в одномерный
{
    int[] newArray = new int [array2D.Length];
    int k = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            newArray[k] = array2D[i,j];
            k++;
        } 
    }
    return newArray;
}

void PrintArray(int[] array) // печатаем одномерный массив
{
    for (int i = 0; i < array.Length; i++) 
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, "); 
        else Console.Write($"{array[i]} ");
    }
}

void CountElement (int [] arr) // считаем колличество элементов в массиве
{
    int num = arr [0];
    int count = 1;
    for (int i = 1; i < arr.Length-1; i++) 
    {
        if (arr [i] == num) count++;
        else
        {
           Console.WriteLine($"{num} встречается {count} раз");
           num = arr [i];
           count = 1;
        }
    }
        Console.WriteLine($"{num} встречается {count} раз"); 

}

int[,] array2D = CreateMatrixRndInt(4, 5, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();

int[] array = NewArray(array2D);
Array.Sort(array);
PrintArray (array);

Console.WriteLine();
CountElement (array);