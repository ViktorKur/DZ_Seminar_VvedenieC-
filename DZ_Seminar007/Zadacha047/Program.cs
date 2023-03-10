// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int VvodParametrMassiva(string text)
{
  Console.Write(text);
  int parametr = Convert.ToInt32(Console.ReadLine());
  return parametr;
}

double[,] ZapolnenMatrix(int strok, int stolb, int nach, int kon)
{
  Random RND = new Random();
  double[,] matrix = new double[strok, stolb];
  for (int i = 0; i < strok; i++)
  {
    for (int j = 0; j < stolb; j++)
    {
      matrix[i, j] = Convert.ToDouble(Math.Round(RND.Next(nach, kon + 1) + RND.Next(0, 10) / 10.0, 1));
    }
  }
  return matrix;
}

void PrintMatrix(double[,] prnMatrix)
{
  for (int i = 0; i < prnMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < prnMatrix.GetLength(1); j++)
    {
      Console.Write(prnMatrix[i, j] + "\t");
    }
    System.Console.WriteLine();
  }
}
void Main()
{
  int m = Convert.ToInt32(VvodParametrMassiva("Введите количество строк 2х мерного массива: "));
  int n = Convert.ToInt32(VvodParametrMassiva("Введите количество столбцов 2х мерного массива: "));
  if (m > 0 && n > 0)
  {
    int min = Convert.ToInt32(VvodParametrMassiva("Введите начальное значение для генератора случайных чисел: "));
    int max = Convert.ToInt32(VvodParametrMassiva("Введите конечное значение для генератора случайных чисел: "));
    System.Console.WriteLine();
    if (max > min)
    {
      double[,] matr = new double[m, n];
      matr = ZapolnenMatrix(m, n, min, max);
      PrintMatrix(matr);
    }
    else System.Console.WriteLine("Начальное значение в генераторе случайных чисел не может быть больше конечного, введите данные заново");
  }
  else System.Console.WriteLine("Размерность матрицы не может бытьменьше или равна нулю, введите данные заново");
}

Console.Clear();
Main();
System.Console.WriteLine();