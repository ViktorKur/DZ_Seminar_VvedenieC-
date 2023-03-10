// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int VvodParametrMassiva(string text)
{
  Console.Write(text);
  int parametr = Convert.ToInt32(Console.ReadLine());
  return parametr;
}

int[,] ZapolnenMatrix(int strok, int stolb, int nach, int kon)
{
  Random RND = new Random();
  int[,] matrix = new int[strok, stolb];
  for (int i = 0; i < strok; i++)
  {
    for (int j = 0; j < stolb; j++)
    {
      matrix[i, j] = RND.Next(nach, kon + 1);
    }
  }
  return matrix;
}

void PrintMatrix(int[,] prnMatrix)
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

void SrednArifm(int[,]matrix)
{
  double srArifm =0; 
  for (int i =0; i<matrix.GetLength(0); i++)
  {
    int sum = 0;
    for (int j=0; j<matrix.GetLength(1); j++)
    {
     sum += matrix[j,i];  
    }
    srArifm=Math.Round((sum/Convert.ToDouble(matrix.GetLength(0))), 2);
    System.Console.WriteLine($"Среднее арифметическое элементов {i+1} столбца = {srArifm}");
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
      int[,] matr = new int[m, n];
      matr = ZapolnenMatrix(m, n, min, max);
      PrintMatrix(matr);
      System.Console.WriteLine();
      SrednArifm (matr);
    }
    else System.Console.WriteLine("Начальное значение в генераторе случайных чисел не может быть больше конечного, введите данные заново");
  }
  else System.Console.WriteLine("Размерность матрицы не может бытьменьше или равна нулю, введите данные заново");
}

Console.Clear();
Main();
System.Console.WriteLine();