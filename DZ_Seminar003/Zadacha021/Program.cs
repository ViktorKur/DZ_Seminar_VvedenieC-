// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
double[] CoordArr(string text)
{
  double[] CorArr = new double [3];
  System.Console.WriteLine(text);
  for (int i = 0; i < 3; i++)
  {
    CorArr[i] = Convert.ToDouble(Console.ReadLine());
  }
  return CorArr;
}

double Rastoyin(double[] A, double[] B)
{
  double Rast = double.Round(Math.Sqrt(Math.Pow((A[0] - B[0]),2 ) + Math.Pow((A[1] - B[1]),2) + Math.Pow((A[2] - B[2]),2)),2);
return Rast;
}

double[] TA = new double[3]; double[] TB = new double[3];
TA = CoordArr("Введите координаты точки А(X,Y,Z)");
TB = CoordArr("Введите координаты точки B(X,Y,Z)");
Console.WriteLine("Расстояние между точками A(" + string.Join(", ", TA) + ") и B(" + string.Join(", ", TB) + ") = " + string.Join("", Rastoyin(TA, TB)));

