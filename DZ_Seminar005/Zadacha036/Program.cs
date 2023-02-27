// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] VvodDan(string text)
{
  int[] arr = new int[3];
  System.Console.WriteLine(text);
  arr = Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse);
  return arr;
}

void PrintResult(int[] parA, int sumN)
{
  System.Console.WriteLine($"Сгенерированный массив случайных чисел: [" + string.Join(",", parA) + $"] и сумма значений на нечетных позициях => {sumN}");
}


int[] RNDMAS(int[] parAr)
{
  int[] rndMassiv = new int[parAr[0]];
  Random rnd = new Random();
  for (int i = 0; i < rndMassiv.Length; i++)
  {
    rndMassiv[i] = rnd.Next(parAr[1], parAr[2] + 1);
  }
  return rndMassiv;
}

int SUMNech(int[] rndM)
{
  int sumNech = 0;
  for (int i = 0; i < rndM.Length; i++)
  {
    if (i % 2 != 0)
    {
      sumNech = sumNech + rndM[i];
    }
  }
  return sumNech;
}

void Main(int[] par)
{
  if (par[0] > 0)
  {
    if (par[2] > par[1])
    {
      int[] rndMass = new int[par[0]];
      rndMass = RNDMAS(par);
      int sumNch = SUMNech(rndMass);
      PrintResult(rndMass, sumNch);
    }
    else System.Console.WriteLine("Макс.значение генератора случайных чисел не может быть меньше Мин. значения. Введите все данные заново");
  }
  else System.Console.WriteLine("Число ячеек в массиве не может быть меньше либо равно нулю, введите все данные заново");
}

Console.Clear();
int[] parArr = new int[3];
parArr = VvodDan("Введите через запятую параметры массива и генератора случейных чисел (число ячеек, мин. зн., макс зн.)");
Main(parArr);