// Задача 35: 
// 1. Задайте одномерный массив из 123 случайных чисел.
// 2. Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] CreateArrayRndInt(int size, int min, int max)//1. делаем метод на создание массива
                                                   // в задаче нужно задать конкретный массив, а не случайное заполнение
{
    int[] array = new int[size]; // если [] после int, то это массив
    Random rnd = new Random(); //вводим переменную Random на рандомное число, либо var
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1); // говорим, что array[i] = rnd Next (min, max+1)
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
    Console.WriteLine("]");
}

int SearchArrayNumb(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99) count++;
    }
    return count;
}

int[] arr = CreateArrayRndInt(123, 0, 999); //{3,5,6,6,3}; применяем массив 5-размер массива, 0, 10 - диапазон
PrintArray(arr);
int count = SearchArrayNumb(arr);
Console.WriteLine($" количество элементов массива, значения которых лежат в отрезке [10, 99]");

