﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    array [i, j] = Convert.ToInt32(new Random().Next(0,21));
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    Console.Write(array[i, j] + "\t");
    Console.WriteLine();
}

Console.WriteLine("Введите координаты");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a>m && b>n)
Console.WriteLine("Такого числа нет");
else
{
    object c = array.GetValue(a=a-1, b=b-1);
    Console.WriteLine(c);
}