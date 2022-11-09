// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите номер строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int n = Convert.ToInt32(Console.ReadLine());

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

int FindElement(int[,] arr, int num1, int num2)
{
    int find = default;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == num1 && j == num2)
                find = arr[i, j];
        }
    }
    return find;
}


bool Element(int[,] arr, int num1, int num2)
{
    {
        return (num1 >= 0 && num1 < arr.GetLength(0) && num2 >= 0 && num2 < arr.GetLength(1));
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 0, 9);
PrintMatrix(array2d);
// int findElement = FindElement(array2d, m, n);
bool element = Element(array2d, m, n);
if (element) Console.WriteLine($"значение  элементов {m} и {n}");
else Console.WriteLine($"Такого элемента не существует");



