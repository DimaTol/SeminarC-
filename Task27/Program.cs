// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму 
// цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0)
    Console.Write("Введите положительное число");

else
{
    int SummNumbers(int num)
    {
        int summ = 0;

        while (num > 0)
        {

            summ = summ + num % 10;  // или так: summ += num % 10;
           
            num = (num - num % 10) / 10; // или так: num /= 10;
            
        }
        return summ;

    }
    int summNumb = SummNumbers(num);

    Console.WriteLine($"{num} -> {summNumb}");
}