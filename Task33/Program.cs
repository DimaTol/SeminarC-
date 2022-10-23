// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
Console.WriteLine("Введите число  ");
int number = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size, int min, int max)// делаем метод на создание массива
                                                    // в задаче нужно задать конкретный массив, а не случайное заполнение
{
    int[] array = new int[size];
    Random rnd = new Random(); // либо var
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray (int [] array) //далем метод для вывода на печать массив через Void
{
    Console. Write ("[");
    for (int i = 0; i < array.Length; i++) // цикл
    {
        if (i < array.Length -1) Console.Write($"{array[i]}, "); //выводим с запятой пока i меньше массива
        else Console.Write ($"{array[i]} ");// иначе без запятой
    }
    Console.WriteLine("]");
}

bool SearchArrayNumb (int[] array, int num) // делаем метод на поиск числа в массиве (булевый тип правда или ложь)
{
    bool result = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) // перебираем массив
        {
            result = true;
            break; // стоп как будет найден
        }
    }
    return result;
}

int [] arr = CreateArrayRndInt (5,0,10); //применяем массив 5-размер массива, 0, 10 - диапазон
PrintArray(arr); // напечатали массив
bool find = SearchArrayNumb (arr, number);
// if (find) Console.WriteLine ("Да"); // проверили результат да или нет
// else Console.WriteLine("Нет");
Console.WriteLine(find ? "да" : "нет"); //или использовать тернарный оператор
