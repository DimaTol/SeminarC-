// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
int [] CreateArrayRndInt (int size, int min, int max) // выводим массив
{
    int [] array = new int [size]; // задаем массив
    Random rnd = new Random (); // либо var
    for (int i = 0; i < size; i++) // цикл
    {
        array [i] = rnd. Next (min, max + 1); // решение
    }
    return array; // возвращаем переменную
}

void PrintArray (int [] array) // вывод на печать массив через Void
{
    Console. Write ("[");
    for (int i = 0; i < array.Length; i++) // цикл
    {
        if (i < array.Length -1) Console.Write($"{array[i]}, "); //выводим с запятой пока i меньше массива
        else Console.Write ($"{array[i]} ");// иначе без запятой
    }
    Console.WriteLine("]");
}

void InversArrayElem (int [] array) // метод по решению задачи на переворот массива
{
    for (int i = 0; i < array.Length; i++) // цикл
    {
        array[i] = -array [i]; // само решение
    }
  
}

int[] arr = CreateArrayRndInt (12, -19, 19); // используем массив 
PrintArray (arr); // вывод методов на печать
InversArrayElem (arr);
PrintArray (arr);