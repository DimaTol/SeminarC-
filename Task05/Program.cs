Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32 (Console.ReadLine());

int lastdigit = number % 10;

Console.WriteLine($"Последняя цифра числа => {lastdigit}");