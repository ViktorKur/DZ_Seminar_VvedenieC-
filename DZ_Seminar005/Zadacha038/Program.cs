// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] VvodDan(string text)
{
  int[] arr = new int[3];
  System.Console.WriteLine(text);
  arr = Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse);
  return arr;
}

void PrintResult(double[] parA, double razN)
{
  System.Console.WriteLine($"Сгенерированный массив случайных вещественных чисел: [" + string.Join(",", parA) + $"] и между Макс и Мин числами массива => {razN}");
}


double[] RNDMAS(int[] parAr)
{
  double[] rndMassiv = new double[parAr[0]];
  Random rnd = new Random();
  for (int i = 0; i < rndMassiv.Length; i++)
  {
    rndMassiv[i] = rnd.Next(parAr[1], parAr[2] + 1) + Convert.ToDouble(rnd.Next(10)/10);
    // System.Console.WriteLine(rndMassiv[i]);
  }
  return rndMassiv;
}

double RaznMinMax(double[] rndM)
{
  double min = rndM[0]; double max = rndM[0];
  for (int i = 0; i < rndM.Length; i++)
  {
    if (max<rndM[i]) max = rndM[i];
    else if (min>rndM[i]) min=rndM[i];
  }
  double razn = max-min;
  return razn;
}

void Main(int[] par)
{
  if (par[0] > 0)
  {
    if (par[2] > par[1])
    {
      double[] rndMass = new double[par[0]];
      rndMass = RNDMAS(par);
      double raznMinMax = RaznMinMax(rndMass);
      PrintResult(rndMass, raznMinMax);
    }
    else System.Console.WriteLine("Макс.значение генератора случайных чисел не может быть меньше Мин. значения. Введите все данные заново");
  }
  else System.Console.WriteLine("Число ячеек в массиве не может быть меньше либо равно нулю, введите все данные заново");
}

Console.Clear();
int[] parArr = new int[3];
parArr = VvodDan("Введите через запятую параметры массива и генератора случейных чисел (число ячеек, мин. зн., макс зн.)");
Main(parArr);