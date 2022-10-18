// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;
int j = 0;
int lenght = number.ToString().Length;
string str = number.ToString();

for (i = 0; i < lenght / 2; i++)
if (str[i] == str[lenght - 1 - i])
{
j++;
}
if (j == lenght / 2)
{
    Console.WriteLine("Введенное число палиндром");
}
else
{
    Console.WriteLine("Введенное число не является палиндромом");
}



// Console.Write ("Введите число : ");
// int number = Convert.ToInt32(Console.ReadLine());
// int j = 0;
// int lenght = number.ToString().Length;
// string str = number.ToString();

// for (int i = 0; i < lenght / 2; i++)
// if (str[i] == str [lenght-1-i])
// {
//     j ++;
// }
//     if (j == lenght / 2)
//     {
//         Console.WriteLine ("Введенное число палиндром");
//     }
//     else
//     {
//     Console.WriteLine ("Введенное число не является палиндромом");
//     }