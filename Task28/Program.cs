// Задача 28: Задача на факториал
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Factorial(int num)
{
    int fact = 1;
    for (int i = 1; i <= num; i++)
    {
        checked // оператор переполнения
        {
        fact = fact * i;
        }
    }
    return fact;
}
int factorial = Factorial(num);

Console.WriteLine(factorial);