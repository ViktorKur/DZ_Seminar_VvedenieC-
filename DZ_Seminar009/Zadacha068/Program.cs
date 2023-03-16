// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int VvodZnach(string textVvoda) // Ввод с терминала целых неотрицательных значений N и М
{
  Console.Write(textVvoda);
  int zn = Convert.ToInt32(Console.ReadLine());
  return zn;
}

int RecursAkkerman(int m, int n) // Расчет функции Аккермана с помощью рекурсии и отправляет результата в Main на вывод в терминал
{
  if (m == 0)
  {
    return n + 1;
  }
  if (m > 0 && n == 0)
  {
    return RecursAkkerman(m - 1, 1);
  }
  return RecursAkkerman(m - 1, RecursAkkerman(m, n - 1));
}

void Main() // Запрос и проверка значений M и N на положительность. Запрос на расчет функции Аккермана и вывод на терминал результата
{
  Console.WriteLine("Введите неотрицательные целые чисела M и N для вычисления функции Аккермана A(m,n): ");
  int znM = VvodZnach("Введите целочисленное значение M:");
  int znN = VvodZnach("Введите целочисленное значение N:");

  if (znN >= 0 && znM >= 0)
  {
    Console.WriteLine($"Функция Аккермана A({znM},{znN}) = {RecursAkkerman(znM, znN)}");
    Console.WriteLine();
  }
  else
  {
    Console.WriteLine("Вводимые значения M и N дожны быть неотрицательными целыми числами, попробуйте ввести еще раз");
  }
}

Console.Clear();
Main();