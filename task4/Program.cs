// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int index = 1;
if (index == 1)
{
    index += 1;
}
    while (index <= a)
    {
       Console.WriteLine(index);
       index += 2; 
    }
