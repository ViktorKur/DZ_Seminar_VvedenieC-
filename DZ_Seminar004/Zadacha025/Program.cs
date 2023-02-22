// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
int[] VhodZn(string text)
{
  int[] Zn = new int[2];
  System.Console.WriteLine(text);
  Zn[0] = Convert.ToInt32(Console.ReadLine());
  Zn[1] = Convert.ToInt32(Console.ReadLine());
  return Zn;
}

int Stepen(int[] num)
{
  int st = 1;
  for (int i = 1; i <= num[1]; i++)
  {
    st = num[0] * st;
  }
  return st;
}

void Print(int[] VZn, int rez)
{

  if (VZn[1] > 0)
  {
    System.Console.WriteLine($"Веденное Вами число А ({VZn[0]}) возведенное степень B ({VZn[1]}) = {rez}");
  }
  else System.Console.WriteLine(" Некорректно введено значение степени, число В.  ");
}

int[] stArr = VhodZn("Введите два числа A и B, где число А будет возводиться в натуральную степень B: ");
int st = Stepen(stArr);
Print(stArr, st);
