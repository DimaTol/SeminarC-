// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32 (Console.ReadLine());

int secondNumber = (number % 100) / 10;

Console.WriteLine($"Вторая цифра числа {number} => {secondNumber}");