﻿// Задача 43. Программа, которая ищет точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();
Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());
double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;
Print();

void Print()
{
if  (k1 == k2)
{
    Console.WriteLine($"прямые не пересекаются");
}
else
Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
}