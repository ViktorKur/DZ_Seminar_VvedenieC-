// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// // на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num>99 && num<1000 )
{
  int secnum= num/10-num/100*10;
  System.Console.WriteLine($"Второй цифрой по счету введенного вами числа {num} является -> {secnum}");
  return;
}
else System.Console.WriteLine("Введенное вами число не является трехзначным ");
