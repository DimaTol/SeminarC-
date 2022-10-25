// Задача 34: 
// 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
// 2. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)//1. делаем метод на создание массива

{
    int[] array = new int[size];
    Random rnd = new Random(); //вводим переменную Random на рандомное число, либо var
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(100, 999); //задаем диапазон числа массива
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

int EvenNumbersCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++; //проверяем на четность
    }
    return count;
}

int[] arr = CreateArrayRndInt(7, 0, 9);
PrintArray(arr);
int count = EvenNumbersCount(arr);
Console.Write(count);

