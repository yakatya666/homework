// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int Number2 = Convert.ToInt32(Console.ReadLine());

int stepen(int Number1, int Number2)
{
  int result = 1;
  for(int i = 1; i <= Number2; i++)
  {
    result = result * Number1;
  }
    return result;
}

  int Stepen = stepen(Number1, Number2);
  Console.WriteLine("Число " + Number1 + " в степени " + Number2 + " = " + Stepen);