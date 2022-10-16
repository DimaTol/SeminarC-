// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int number = 23534;
if (Check(number))
{
    int res = Method(number);
}
else {}

bool Check (int num)
{
    return number >= 100 & number <= 999; // возвращает true или false 
    // или так
    // res = number >= 100 & number <= 999;
    // return res;
}

int Method(int num);
{
    return num / 10 % 10; // 345
}