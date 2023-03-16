// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int VvodZnach(string textVvoda) // Ввод с терминала целого значения N
{
  Console.Write(textVvoda);
  int n = Convert.ToInt32(Console.ReadLine());
  return n;
}

void RecursZnach(int m)
{
  if (m >= 1)
  {
    PrintZn(m); RecursZnach(m - 1);
  }
}

void PrintZn(int k)
{
  System.Console.Write($"{k}, ");
}

void Main()
{
  int Zn = VvodZnach("Введите целочисленное значение N:");
  if (Zn >= 1)
  {
    System.Console.WriteLine("Все натуральные числа в промежутке от N до 1 => ");
    RecursZnach(Zn);
  }
  else System.Console.WriteLine("Вводимое значение N должно быть больше или рано 1, введите значение заново");
}
Console.Clear();
Main();