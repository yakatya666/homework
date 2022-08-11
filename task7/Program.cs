// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void Week (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine("(Это выходной день");
  }
  else if (dayNumber < 1 || dayNumber > 7) 
  {
    Console.WriteLine("Такого дня нет");
  }
  else Console.WriteLine("Это будний день");
}

Week(dayNumber);
