// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
int VvodDan(string text)
{
  System.Console.WriteLine(text);
  int chislo = Convert.ToInt32(Console.ReadLine());
  return chislo;
}
int Sum (int Ch)
{
  int Ost = 0;
  while (Ch > 0 )
  {
    Ost=Ost+Ch%10;
    Ch=Ch/10; 
  }
   return Ost;
}

void Print (int Zn, int Sum)
{
  System.Console.WriteLine($"Введенное Вами число ({Zn}), сумма входящих в него чисел = {Sum} ");
}


void main(int Zn)
{
if (Zn/10>=0) 
{
  int SumCh = Sum(Zn);
  Print (Zn, SumCh);
 }
 else 
 {
  int SumCh = Sum( Math.Abs(Zn));
  Print (Zn, SumCh*-1);
 }
}

int Zn = VvodDan("Введите пожалуйста любое целое число : ");
main (Zn);