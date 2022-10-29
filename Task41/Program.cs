// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
Console.WriteLine("Сколько чисел будете вводить? ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num]; // преобразуем числа в массив, которые ввел пользователь

for (int i = 0; i < num; i++)
{
    Console.WriteLine($"Введите число ({i})");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array) //далем метод для вывода на печать массив через Void
{
    Console.Write(" ");
    for (int i = 0; i < array.Length; i++) // цикл
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, "); //выводим с запятой пока i меньше массива
        else Console.Write($"{array[i]} ");// иначе без запятой
    }
    Console.Write(" ");
}


int CountNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count ++;
    }
    return count;

}
// InputNumbers (num);
int countNum = CountNum(array);
PrintArray (array);
Console.Write($"-> {countNum}");





