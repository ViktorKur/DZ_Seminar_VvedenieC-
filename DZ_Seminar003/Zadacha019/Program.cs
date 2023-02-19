// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
int VhodZn(string text)
{
  System.Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
}

int Count(int num)
{
  int i = 0;
  while (num > 0)
  {
    num = num / 10; i++;
  }
  return i;
}

string Palidrom(int pol)
{
  int ls = 0; int rs = 0;
  ls = pol / 1000; rs = pol % 10 * 10 + (pol % 100 - pol % 10) / 10;
  if (ls == rs)
  {
    return "является палиндромом";
  }
  else return "не является палиндромом";
}

int Zn = VhodZn("Введите пятизначное значение");
int i = Count(Zn);
if (i == 5)
{
  System.Console.WriteLine($"{Zn}, {i}");
  System.Console.WriteLine($"Введенное вами число {Zn} - {Palidrom(Zn)}");
}
else
{
  System.Console.WriteLine("Ведено не пятизнаное число, повторите попытку");
}