// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

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

// int SummElementString(int[,] summArray, int i, int j)
// {
//     int summ = summArray [i,0];
//     {
//         for (j = 1; j < summArray.GetLength(1); j++)
//         {
//             {
//                 if (summArray[i, j] < summArray.GetLength(1) - 1)
//                 {
//                     summ += summArray [i,j];
//                 }
//             }
//         }
//     }
//     return summ;
// }


int MinSummLine(int[,] array)
{
    int temp;
    int temp2 = 0;
    int minline = 0;
    for (int j = 0; j < array.GetLength(1); j++) //сумма элементов первой строки, отправная точка
        temp2 += array[0, j];
    Console.WriteLine(temp2); //справочно - вывод суммы в строке
    for (int i = 1; i < array.GetLength(0); i++) //сравнение суммы первой строки с остальными строками и поиск наименьшей
    {
        temp = 0;
        for (int j = 0; j < array.GetLength(1); j++) //вычисление суммы элементов строки
            temp += array[i, j];
        Console.WriteLine(temp); //справочно - вывод суммы в строке
        if (temp < temp2)
        {
            minline = i; //запоминание строки с минимальной суммой
            temp2 = temp; //запоминание минимального числа для последующего сравнения
        }
    }
    return minline + 1;
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();
int minSummLine = MinSummLine(array2d);
Console.WriteLine("Минимальная сумма элементов в строке номер " + minSummLine);




