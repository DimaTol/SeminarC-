// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
string num = Console.ReadLine();

string result  = Range (num); // 2 - применили этот метод
Console.WriteLine(result);

string Range (string number) // 1 - сделали Метод, который возвращает значение
{
    if (number == "1") return "x > 0 и y > 0";
    if (number == "2") return "x < 0 и y > 0";
    if (number == "3") return "x < 0 и y < 0";
    if (number == "4") return "x > 0 и y < 0";

    return "Ошибка ввода";
}