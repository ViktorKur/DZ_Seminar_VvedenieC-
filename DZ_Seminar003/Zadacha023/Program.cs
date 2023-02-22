// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
int VhodZn(string text)
{
  System.Console.WriteLine(text);
  int N = Convert.ToInt32(Console.ReadLine());
  return N;
}

double[] TablKub(int num)
{
  double[] kub = new double[num];
  for (int i = 0; i < num; i++)
  {
    kub[i] = Math.Pow((i + 1), 3);
  }
  return kub;
}

void PrintTab(int Zn)
{
  if (Zn > 0) System.Console.WriteLine($"От введенного Вами числа {Zn}, таблица кубов = >  " + String.Join(", ", TablKub(Zn)));
   else System.Console.WriteLine("Число N должно быть больше нуля, попробуйте ещё раз");
}

  int N = VhodZn("Введите число (N) для расчета таблицы кубов чисел от 1 до N : ");
  PrintTab(N);