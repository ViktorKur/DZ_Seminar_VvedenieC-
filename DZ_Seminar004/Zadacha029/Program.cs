// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Clear();

int VvodKolArr(string txt1)
{
  System.Console.WriteLine(txt1);
  int indx = Convert.ToInt32(Console.ReadLine());
  return indx;
}
double[] ZapArr(int N, string txt2)
{
  double[] Massiv = new double[N];
  System.Console.WriteLine(txt2);
  for (int i = 0; i < N; i++)
  {
    System.Console.Write($"Введите {i} элемент массива: ");
    Massiv[i] = Convert.ToDouble(Console.ReadLine());
  }
  return Massiv;
}
void Prn(int n, double[] Arr)
{
  System.Console.WriteLine($"Введенный Вами массив из {n} элементов => [" + string.Join(", ", Arr) + "]");
}


int n = VvodKolArr("Введите количество элементов массива: ");
if (n > 0)
{
  double[] Arr = new double[n];
  Arr = ZapArr(n, "Введите поочереди через Enter каждый элемент массива");
  Prn(n, Arr);
}
else System.Console.WriteLine("Количество элементов массива не может быть отрицательным или равно нулю, попробуйте еще раз");