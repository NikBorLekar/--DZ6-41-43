// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine($"Введите число М(количество чисел): ");
int M = Convert.ToInt32(Console.ReadLine());
int[] Num = new int[M];

void Num1(int m)
{
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    Num[i] = Convert.ToInt32(Console.ReadLine());
  }
}

int Sravn(int[] Num2)
{
  int count = 0;
  for (int i = 0; i < Num2.Length; i++)
  {
    if(Num2[i] > 0 ) count += 1; 
  }
  return count;
}

Num1(M);
Console.WriteLine($"Пользователь ввел чисел больше нуля- {Sravn(Num)} ");