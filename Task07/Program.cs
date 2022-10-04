//11. Напишите программу, которая выводит случайное
//трёхзначное число и удаляет вторую цифру этого
//числа.



int number = new Random().Next(100, 1000);
Console.WriteLine($"случайное число {number}");
int firstDigit = number / 100;
int thirdDigit = number % 10;

Console.WriteLine($"{firstDigit}{thirdDigit}");
