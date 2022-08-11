 // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
string Text = Convert.ToString(a);
if (Text.Length > 2)
{
  Console.WriteLine("третья цифра -> " + Text[2]);
}
else 
{
  Console.WriteLine("-> третьей цифры нет");
}