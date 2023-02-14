// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
System.Console.Write("Введите любое целое число и программа выведет третью по счету цифру: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0; int n = num;
if (num > 99)
{
  while (n > 0)
  {
    n = n / 10; i++;
  }
  int m = Convert.ToInt32(Math.Pow(10, i - 3));
  int num3 = (num / m) % 10;
  System.Console.WriteLine($"Третьей по счету цифрой введенного вами числа {num} является -> {num3}");
  return;
}
else System.Console.WriteLine("Введенном Вами числе нет третьей цифпы! ");
