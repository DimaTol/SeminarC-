// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
//  M = 1; N = 15 -> 120
//  M = 4; N = 8. -> 30

Console.WriteLine("Введите целое число: ");
int numberM = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите целое число: ");
int numberN = Convert.ToInt32 (Console.ReadLine());

int SummElements (int numM, int numN)
{
    int summ = default;
        if (numM <= numN)
        return summ = summ + numM + SummElements(numM+1, numN);
        else return summ;
}
int summ1 = SummElements (numberM, numberN);
int summ2 = SummElements (numberN, numberM);

if (numberM <= numberN)
{
Console.WriteLine($"M = {numberM}; N = {numberN} -> {summ1}");
}
else
Console.WriteLine($"M = {numberN}; N = {numberM} -> {summ2}");

