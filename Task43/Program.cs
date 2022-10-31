// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите координаты X точки B1 ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y точки K1 ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты X точки B2 ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y точки K2 ");
double k2 = Convert.ToInt32(Console.ReadLine());


void IntersectPoint(double xb1, double yk1, double xb2, double yk2)
{
    double x = (xb1 - xb2) / (yk2 - yk1);
    double y = (yk2 * x) + xb2;
    Console.Write($"Точка пересечения двух прямых с координатами b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2},  -> ({x};{y})");
}
IntersectPoint(b1, k1, b2, k2);

