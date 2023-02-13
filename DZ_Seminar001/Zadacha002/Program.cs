// Задача 2: Напишите программу, которая на вход принимает два числа
//  и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
  Console.WriteLine($"Первое число {num1} больше чем второе {num2} таким образом max = {num1}");
}
  else if (num2 > num1)
    {
      Console.WriteLine($"Второе число {num2} больше чем первое {num1} таким образом max = {num2}");
    }
       else Console.WriteLine($"Введенные Вами числа {num1} и {num2} равные");
