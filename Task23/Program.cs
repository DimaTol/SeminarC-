// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


int Cube(int number)
{
    int cube =0;
    int count = 0;
    for (int i = 0; i <= number; i++)
    {
        cube = count * count * count;
        Console.WriteLine($"{count}|{cube}");
        count++;
    }
    return cube;
}

int cube = Cube(number);


