// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
System.Console.Write("Введите число N, для проверки интервала от 1 до N на четность: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num==0 || num<0) 
{
  System.Console.WriteLine($"Введенное Вами число {num} не отвечает условию задачи, т.е. не входит в от 1 до N");
  return;
}
System.Console.WriteLine("Ряд четных чисел от от 1 до N: ");
for (int i=1; i < num+1; i++)
{
if (i%2==0) System.Console.Write($"{i}; ");
}
