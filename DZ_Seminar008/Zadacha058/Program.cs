// Задача 58: Задайте две матрицы. Напишите программу,
//  которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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
      Console.Write(Math.Round(prnMatrix[i, j], 1) + "\t");
    }
    System.Console.WriteLine();
  }
}

double[,] UslovZapolnMatrix()
{
  try
  {
    double[,] nul = { { 0 }, { 0 } };
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
        return matr;
      }
      else throw new Exception("Начальное значение в генераторе случайных чисел не может быть больше конечного, введите данные заново");
    }
    else throw new Exception("Размерность матрицы не может бытьменьше или равна нулю, введите данные заново");
  }
  catch (Exception e)
  {
    Console.WriteLine($"Ошибка: {e.Message}");
    throw;
  }
}

void PeremnojenieMatrix(double[,] matrix1, double[,] matrix2)
{
  if (matrix1.GetLength(0) == matrix2.GetLength(1) && matrix1.GetLength(1) == matrix2.GetLength(0))
  {
    double[,] proizvMatrix = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
      for (int j = 0; j < matrix2.GetLength(1); j++)
      {
        for (int n = 0; n < matrix1.GetLength(1); n++)
        {
          proizvMatrix[i, j] += matrix1[i, n] * matrix2[n, j];
        }
      }
    }
    System.Console.WriteLine();
    System.Console.WriteLine("Результат умножения первой матрицы на вторую :");
    PrintMatrix(proizvMatrix);
  }
  else System.Console.WriteLine("Умножение не возможно! Количество строк первой матрицы не равно количеству столбцов второй матрицы.");
}

void Main()
{
  Console.Clear();
  System.Console.WriteLine("Заполнение параметров первой матрицы");
  System.Console.WriteLine("Количество строк первой матрицы должно быть равно количеству столбцов второй матрицы.");
  double[,] matr = UslovZapolnMatrix();
  double[,] matr1 = new double[matr.GetLength(0), matr.GetLength(1)];
  matr1 = matr;
  System.Console.WriteLine("Заполнение параметров второй матрицы");
  System.Console.WriteLine("Количество строк первой матрицы должно быть равно количеству столбцов второй матрицы.");
  double[,] matr0 = UslovZapolnMatrix();
  double[,] matr2 = new double[matr0.GetLength(0), matr0.GetLength(1)];
  matr2 = matr0;
  System.Console.WriteLine("Сгенерированная первая матрица");
  PrintMatrix(matr1);
  System.Console.WriteLine();
  System.Console.WriteLine("Сгенерированная вторая матрица");
  PrintMatrix(matr2);
  PeremnojenieMatrix(matr1, matr2);
  System.Console.WriteLine();
}

Main();