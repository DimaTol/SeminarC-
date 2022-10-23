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

Cube(number);
void Cube(int number)
{
    int count = 1;
    while (count <= number)
    {
        int cube = count * count * count;
        Console.WriteLine($"{count}|{cube}");
        count++;
    }
}
