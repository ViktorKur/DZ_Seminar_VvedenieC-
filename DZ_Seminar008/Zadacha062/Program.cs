// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int VvodParametrMassiva(string text)
{
  Console.Write(text);
  int parametr = Convert.ToInt32(Console.ReadLine());
  return parametr;
}

void PrintMatrix(int[,] prnMatrix)
{
  for (int i = 0; i < prnMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < prnMatrix.GetLength(1); j++)
    {
      System.Console.Write(prnMatrix[i, j] + "\t");
    }
    System.Console.WriteLine();
  }
}

int[,] ZapolnenMatrix(int stroki, int stolb)
{
  int[,] matrix = new int[stroki, stolb];
  int kolZnach = 1;
  int i = 0; int j = 0;
  while (kolZnach <= matrix.GetLength(0) * matrix.GetLength(1))
  {
    matrix[i, j] = kolZnach;
    kolZnach = kolZnach + 1;
    if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
      j = j + 1;
    else if (i < j && i + j >= matrix.GetLength(0) - 1)
      i = i + 1;
    else if (i >= j && i + j > matrix.GetLength(1) - 1)
      j = j - 1;
    else
      i = i - 1;
  }
  return matrix;
}

void Main()
{
  int n = Convert.ToInt32(VvodParametrMassiva("Введите количество строк 2х мерного массива: "));
  int k = Convert.ToInt32(VvodParametrMassiva("Введите количество столбцов 2х мерного массива: "));
  if (n > 0 && k > 0)
  {
    System.Console.WriteLine();
    int[,] matr = new int[n, k];
    matr = ZapolnenMatrix(n, k);
    System.Console.WriteLine("Сгенерированная и заполненная по спирали матрица:");
    PrintMatrix(matr);
    System.Console.WriteLine();
  }
  else System.Console.WriteLine("Размерность матрицы не может бытьменьше или равна нулю, введите данные заново");
}

Console.Clear();
Main();
System.Console.WriteLine();

