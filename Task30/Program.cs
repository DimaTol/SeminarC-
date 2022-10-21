
// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] FillArray(int num)
{
    int[] array = new int[num];
    Random rnd = new Random ();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next (0,2);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}

int[] myArr = FillArray(8);
PrintArray(myArr);
