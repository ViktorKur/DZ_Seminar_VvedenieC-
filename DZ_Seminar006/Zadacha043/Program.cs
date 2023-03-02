// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
double VvodDan(string text)
{
  System.Console.Write(text);
  double num = Convert.ToDouble(Console.ReadLine());
  return num;
}

void RaschetTochkiXandY()
{
  double[] valKB = new double[4];
  double[] koordinatyPeresechen = new double[2];
  valKB[1] = VvodDan($"Введите значение b (1) = ");
  valKB[0] = VvodDan($"Введите значение k (1) = ");
  valKB[3] = VvodDan($"Введите значение b (2) = ");
  valKB[2] = VvodDan($"Введите значение k (2) = ");

  koordinatyPeresechen[0] = Math.Round(((valKB[3]) - valKB[1]) / (valKB[0] - valKB[2]),1);
  koordinatyPeresechen[1] = Math.Round(valKB[2] * koordinatyPeresechen[0] + valKB[3],1);
  System.Console.WriteLine($"Координаты точки пересечения двух прямых = [" + string.Join(";", koordinatyPeresechen) + $"]");
}

RaschetTochkiXandY();