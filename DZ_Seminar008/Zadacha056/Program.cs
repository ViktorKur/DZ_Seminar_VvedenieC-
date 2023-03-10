// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

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

double[] SumLine(double[,] sMatrix)
{
  double[] sumMasiv = new double[sMatrix.GetLength(0)];
  for (int i = 0; i < sMatrix.GetLength(0); i++)
  {
    double sumStr = 0;
    for (int j = 0; j < sMatrix.GetLength(1); j++)
    {
      sumStr += sMatrix[i, j];
    }
    sumMasiv[i] = sumStr;
  }
  return sumMasiv;
}

void MaxMinSumLine(double[] sumArr)
{
  double maxSum = sumArr[0]; int indMax = 0;
  double minSum = sumArr[0]; int indMin = 0;
  for (int i = 0; i < sumArr.Length; i++)
  {
    if (maxSum < sumArr[i])
    {
      maxSum = sumArr[i]; indMax = i;
    }
    else if (minSum > sumArr[i])
    {
      minSum = sumArr[i]; indMin = i;
    }
  }
  System.Console.WriteLine($"{indMin + 1} -я строка является строкой с наименьшей суммой элементов = {Math.Round(minSum, 1)} ");
  System.Console.WriteLine($"{indMax + 1} -я строка является строкой с наибольшей суммой элементов = {Math.Round(maxSum, 1)} ");
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
      MaxMinSumLine(SumLine(matr));
    }
    else System.Console.WriteLine("Начальное значение в генераторе случайных чисел не может быть больше конечного, введите данные заново");
  }
  else System.Console.WriteLine("Размерность матрицы не может бытьменьше или равна нулю, введите данные заново");
}

Console.Clear();
Main();
System.Console.WriteLine();
