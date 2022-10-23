// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Write("Введите номер дня недели: ");
int dayNumber=Convert.ToInt32(Console.ReadLine());
Day(dayNumber);

void Day(int dayNumber)
{
if (dayNumber==6 || dayNumber==7)
{
    Console.WriteLine($"{dayNumber} => Да");
}
else if (dayNumber>0 && dayNumber<6)
{
    Console.WriteLine($"{dayNumber} => Нет");
}
else
{
    Console.WriteLine("Такого дня нет");
}
}
