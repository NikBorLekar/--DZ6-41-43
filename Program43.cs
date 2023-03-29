// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

double[,] Koef = new double[2, 2];
double[] Point = new double[2];

void InKoef()
{
  for (int i = 0; i < Koef.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < Koef.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите коэффициент k: ");
      else Console.Write($"Введите коэффициент b: ");
      Koef[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Result(double[,] coeff)
{
  Point[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
  Point[1] = Point[0] * coeff[0,0] + coeff[0,1];
  return Point;
}

void OutResult(double[,] coeff)
{
  if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]) 
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]) 
  {
    Console.Write($"\nПрямые параллельны");
  }
  else 
  {
    Result(coeff);
    Console.Write($"\nТочка пересечения прямых это ({Point[0]}, {Point[1]})");
  }
}

InKoef();
OutResult(Koef);