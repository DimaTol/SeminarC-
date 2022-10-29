// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

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
    Console.Write("] ");
}

int [] CopyArray (int [] array)  // cоздаем метод для копирования массива
{
    int [] newArray = new int [array.Length]; //создаем новый массив
    for (int i = 0; i < array.Length; i++)
    {
        newArray [i] = array [i]; 
    }
    return newArray;
}

int [] arr = CreateArrayRndInt (5,0,100);
PrintArray (arr);

int [] copyArray = CopyArray (arr);
PrintArray(copyArray);
