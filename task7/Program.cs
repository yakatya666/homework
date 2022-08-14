// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

void Week (int day) 
{
  if (day == 6 || day == 7) 
  {
  Console.WriteLine("(Это выходной день");
  }
  else if (day < 1 || day > 7) 
  {
    Console.WriteLine("Такого дня нет");
  }
  else Console.WriteLine("Это будний день");
}

Week(day);
