// Задача 60. ...Сформируйте трёхмерный массив двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int VvodParametrMassiva(string text)
{
  Console.Write(text);
  int parametr = Convert.ToInt32(Console.ReadLine());
  return parametr;
}

double[,,] ZapolnenMatrix(int m, int n, int k)
{
  Random RND = new Random();
  double[,,] matrix = new double[m, n, k];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      for (int f = 0; f < k; f++)
      {
        matrix[i, j, f] = Convert.ToDouble(Math.Round(RND.Next(10, 100) + RND.Next(0, 10) / 10.0, 1));
      }
    }
  }
  return matrix;
}

void PrintMatrix(double[,,] prnMatrix)
{
  for (int i = 0; i < prnMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < prnMatrix.GetLength(1); j++)
    {
      for (int f = 0; f < prnMatrix.GetLength(2); f++)
      {
        Console.Write(prnMatrix[i, j, f] + $"  ({i},{j},{f})" + "\t");
      }
      System.Console.WriteLine();
    }
    System.Console.WriteLine();
  }
}

void Main()
{
  int m = Convert.ToInt32(VvodParametrMassiva("Введите количество ячеек 3х мерного массива: "));
  int n = Convert.ToInt32(VvodParametrMassiva("Введите количество строк в ячейках 3х мерного массива: "));
  int k = Convert.ToInt32(VvodParametrMassiva("Введите количество столбцов в ячейках 3х мерного массива: "));
  if (m > 0 && n > 0 && k > 0)
  {
    System.Console.WriteLine();
    double[,,] matr = new double[m, n, k];
    matr = ZapolnenMatrix(m, n, k);
    System.Console.WriteLine("Сгенерированный трёхмерный массив двузначных чисел с индексами положения в массиве:");
    PrintMatrix(matr);
    System.Console.WriteLine();
  }
  else System.Console.WriteLine("Размерность матрицы не может бытьменьше или равна нулю, введите данные заново");
}

Console.Clear();
Main();
System.Console.WriteLine();
