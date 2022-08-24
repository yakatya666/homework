// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write($"Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[M];

void InputNumbers(int M)
{
for (int i = 0; i < M; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    massive[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comparison(int[] massive)
{
  int count = 0;
  for (int i = 0; i < massive.Length; i++)
  {
    if(massive[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(M);

Console.WriteLine($"Чисел больше 0: {Comparison(massive)} ");