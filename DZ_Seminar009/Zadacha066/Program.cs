// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int VvodZnach(string textVvoda) // Ввод с терминала целого значения N и М
{
  Console.Write(textVvoda);
  int zn = Convert.ToInt32(Console.ReadLine());
  return zn;
}

void RecursSumZnach(int n, int m, int sum) // Расчет суммы значений между M и N с помощью рекурсии и вывод результата в терминал
{
  if (n == m - 1)
  {
    Console.Write($"{sum} ");
    return;
  }
  sum = sum + n;
  RecursSumZnach(n - 1, m, sum);
}

void Main()
{
  System.Console.WriteLine("Задайте значения M и N, для вычисления суммы натуральных элементов в промежутке от M до N");
  int znM = VvodZnach("Введите целочисленное значение M:");
  int znN = VvodZnach("Введите целочисленное значение N:");
  int sumMN = 0;
  if (znN >= znM)
  {
    Console.Write($"Cумма натуральных элементов в промежутке от {znM} до {znN} = ");
    RecursSumZnach(znN, znM, sumMN);
  }
  else
  {
    System.Console.WriteLine("Так как введенное значение M больше N, то мы меняем значения M и N местами");
    Console.Write($"Cумма натуральных элементов в промежутке от {znN} до {znM} = ");
    RecursSumZnach(znM, znN, sumMN);
  }
}
Console.Clear();
Main();