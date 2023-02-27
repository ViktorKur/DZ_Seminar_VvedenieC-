// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] VvodDan(string txt1)
{
  int[] vdan = new int[3];
  System.Console.WriteLine(txt1);
  vdan = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
  return vdan;
}

int[] GenerRND(int n, int NRND, int KRND)
{
  Random RND = new Random();
  int[] Massiv = new int[n];
  for (int i = 0; i < n; i++)
  {
    Massiv[i] = RND.Next(NRND, KRND + 1);
  }
  return Massiv;
}

int UslChetn(int[] Arr)
{
    int count = 0;
      for (int i = 0; i < Arr.Length; i++)
      {
        if (Arr[i] % 2 == 0)
        {
          count++;
        }
      }
      return count;
}

void Main (int[]num)
{
if (num[0] > 0)
{
  int[] Arr1 = new int[num[0]];
  if (num[1] > 99 && num[1] < 1000)
  {
    if (num[2] > 99 && num[2] < 1000)
    {
      if (num[2]>num[1])
      {
      Arr1 = GenerRND(num[0], num[1], num[2]);
      int n = UslChetn(Arr1);
      System.Console.WriteLine($"Сгенерированный массив случайным образом: [" + string.Join(",", Arr1) + "]  четных чисел в нем -> " + n );
      }
      else Console.WriteLine("Не корректно введены значения, начальное значение должно быть меньше конечного");
    }
    else Console.WriteLine("Не корректно введено конечное значение для генерации случайных чисел должно быть положительным и трехзначным");
  }
  else Console.WriteLine("Не корректно введено начальное значение для генерации случайных чисел должно быть положительным и трехзначным");
}
else Console.WriteLine("Не корректно введено значение количества ячеек массива, оно должно быть больше 0");
}

Console.Clear();
int[] par = new int[3];
par = VvodDan("Ввведите через пробел кол-во ячеек, начальное и конечное трехзначное положительное значение для генератора случайных чисел:");
Main(par);
System.Console.WriteLine();