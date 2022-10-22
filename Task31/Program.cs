// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int [] CreateArrayRndInt (int size, int min, int max)
{
    int [] array = new int [size]; // задаем массив
    Random rnd = new Random (); // либо var
    for (int i = 0; i < size; i++) // цикл
    {
        array [i] = rnd. Next (min, max + 1); // решение
    }
    return array; // возвращаем переменную
}

void PrintArray (int [] array)
{
    Console. Write ("[");
    for (int i = 0; i < array.Length; i++) // цикл
    {
        if (i < array.Length -1) Console.Write($"{array[i]}, "); //выводим с запятой пока i меньше массива
        else Console.Write ($"{array[i]} ");// иначе без запятой
    }
    Console.WriteLine("]");
}

int [] GetSumPositiveNegativElem (int [] array)
{
    int sumNegativ = default;
    int sumPositiv = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sumNegativ +=array [i];
        else sumPositiv += array [i];

    }
    int [] result = {sumNegativ, sumPositiv};
    // result [0] = sumNegativ;
    // result [1] = sumPositiv;
    return new int [] {sumNegativ, sumPositiv};
}


int [] arr = CreateArrayRndInt (12, -9, 9); // пишем условие из задачи
PrintArray (arr);
int[] result = GetSumPositiveNegativElem (arr);

Console.WriteLine($"Сумма положительных чисел = {result [1]}");
Console.WriteLine($"Сумма отрицательных чисел = {result [0]}");

