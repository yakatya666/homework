﻿// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = new double[10];
  for (int i = 0; i < array.Length; i++ )
  {
    array[i] = new Random().Next(1, 10);
    Console.Write(array[i] + " ");
  }

double max = array[0];
double min = array[0];

  for (int i = 1; i < array.Length; i++)
  {
    if (max < array[i])
    {
      max = array[i];
    }
        if (min > array[i])
    {
      min = array[i];
    }
  }

  double decision = max - min;

  Console.WriteLine($"\nРазница между между максимальным ({max}) и минимальным ({min}) элементами: {decision}");
