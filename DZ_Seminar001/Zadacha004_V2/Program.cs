// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Clear();
System.Console.Write("Введите количество чисел для нахождения максимального из них: ");
int N = Convert.ToInt32(Console.ReadLine());
double[] numarr = new double[N];
Console.WriteLine($"Введите {N} чисел поочереди: ");
for (int i = 0; i < numarr.Length; i++)
{
  numarr[i] = Convert.ToDouble(Console.ReadLine());
}
Console.Clear();
double max = numarr[0]; int kolN=0;
System.Console.Write($"Из введенного Вами массива чисел: ");
for (int i = 0; i < numarr.Length; i++)
{
  System.Console.Write($"{numarr[i]}; ");
  if (max < numarr[i]) max = numarr[i];
  else if (max==numarr[i]) kolN++;
}
if (kolN==N) System.Console.WriteLine("Все числа в данном массиве равны");
else 
    {
      System.Console.WriteLine("");
      System.Console.WriteLine($"Максимальным будет число -> {max}");
    }     