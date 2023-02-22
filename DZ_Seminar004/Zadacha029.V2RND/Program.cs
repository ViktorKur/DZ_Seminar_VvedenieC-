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
double[] ZapArr(int N, int min, int max)
{
  double[] Massiv = new double[N];
  Random RND = new Random();
  for (int i = 0; i < N; i++)
  {
    Massiv[i] = RND.Next(min, max + 1);
  }
  return Massiv;
}
void Prn(int n, double[] Arr)
{
  System.Console.WriteLine($"Сгенерированный по Вашим параметрам массив из {n} элементов => [" + string.Join(", ", Arr) + "]");
  System.Console.WriteLine();
}


int n = VvodKolArr("Введите количество элементов массива заполняемого автоматически случайными числами: ");
if (n > 0)
{
  int nach = VvodKolArr("Введите минимальное значание числа массива: ");
  int kon = VvodKolArr("Введите максимальное значание числа массива: ");
  double[] Arr = new double[n];
  Arr = ZapArr(n, nach, kon);
  Prn(n, Arr);
}
else System.Console.WriteLine("Количество элементов массива не может быть отрицательным или равно нулю, попробуйте еще раз");