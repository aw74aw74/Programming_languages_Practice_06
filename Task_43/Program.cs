﻿//---------------------ЗАДАЧА---------------------
/*
Задача 43: Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями
y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

//---------------------РЕШЕНИЕ---------------------

Console.WriteLine("Введите через пробел b1 и k1: ");
string[] st = Console.ReadLine()!.Split(' ');
double b1=int.Parse(st[0]);
double k1=int.Parse(st[1]);
Console.WriteLine("Введите через пробел b2 и k2: ");
st = Console.ReadLine()!.Split(' ');
double b2=int.Parse(st[0]);
double k2=int.Parse(st[1]);

Console.WriteLine($"b1={b1}, k1={k1}, b2={b2}, k2={k2}");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + 2;
Console.WriteLine($"x={x}, y={y}");
