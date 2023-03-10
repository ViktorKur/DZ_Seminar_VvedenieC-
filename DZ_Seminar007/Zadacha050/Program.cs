// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//17 -> такого числа в массиве нет
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

void FindItemIndex(double[,] fMatrix)
{
  int line = Convert.ToInt32(VvodParametrMassiva("Введите индекс строки элемента в двумерном массиве: "));
  int column = Convert.ToInt32(VvodParametrMassiva("Введите индекс столбца элемента в двумерном массиве: "));
  if (line >= 0 && column >= 0 && line <= fMatrix.GetLength(0) && column <= fMatrix.GetLength(1))
  {
    System.Console.WriteLine();
    System.Console.WriteLine($"Значение элемента двумерного массива с индексами [{line}, {column}] = {fMatrix[line, column]} ");
  }
  else System.Console.WriteLine($"Значения элемента как и самой позиции с индексами [{line}, {column}] в нашем двумерном массиве не существует");
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
      System.Console.WriteLine();
      FindItemIndex(matr);
    }
    else System.Console.WriteLine("Начальное значение в генераторе случайных чисел не может быть больше конечного, введите данные заново");
  }
  else System.Console.WriteLine("Размерность матрицы не может бытьменьше или равна нулю, введите данные заново");
}

Console.Clear();
Main();
System.Console.WriteLine();