// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] NewArray(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size = size + 1; //если нечетное, то size = size+1
    int[] newArr = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArr [i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length %2 == 1) newArr [size-1] = array [size-1];
    return newArr;
}

int[] arr = CreateArrayRndInt(6, 0, 6);
PrintArray(arr);

int[] newArray = NewArray(arr);
PrintArray(newArray);
