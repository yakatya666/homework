﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();

void Palindrom(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.Write("Это палиндром!");
  }
  else Console.Write("Это не палиндром!");
}

if (number!.Length == 5)
{
  Palindrom(number);
}
else Console.Write("Введите правильное число");