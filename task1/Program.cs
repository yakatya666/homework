// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.WriteLine("Введите первое число");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int userNumber2 = Convert.ToInt32(Console.ReadLine());
if (userNumber1>userNumber2)
{
    Console.WriteLine("Наибольшее число = " + userNumber1);
    Console.WriteLine("Наименьшее число = " + userNumber2);
}   