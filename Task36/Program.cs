// Задача 36: 
// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)//1. делаем метод на создание массива

{
    int[] array = new int[size];
    Random rnd = new Random(); //вводим переменную Random на рандомное число, либо var
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1); //задаем диапазон числа массива
    }

    return array; // возвращаем переменную
}

void PrintArray(int[] array) //далем метод для вывода на печать массив через Void
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++) // цикл
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, "); //выводим с запятой пока i меньше массива
        else Console.Write($"{array[i]} ");// иначе без запятой
    }
    Console.Write("] -> ");
}

int SummElementOddNum(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            summ = summ + array[i];
        }
    }
    return summ;
}

int[] arr = CreateArrayRndInt(7, 0, 9);
PrintArray(arr);
int summElement = SummElementOddNum(arr);
Console.WriteLine(summElement);
