// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());

int SummNumbers (int num)
{
    if (num == 0) return 0;
    else return num % 10 + SummNumbers (num/10);
}

int summ = SummNumbers (number);
Console.WriteLine(summ);