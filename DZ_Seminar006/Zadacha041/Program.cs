// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


double[] VvodDan(int n, string text)
{
    double[] arr = new double[n];
   for (int i=0;i<n;i++)
   {
  System.Console.Write(text +$"[{i}] элемент массива: ");
  arr [i]= Convert.ToInt32(Console.ReadLine());
  }
  return arr;
}

int SumNol(double[]arr)
{
int sum=0;
for (int i=0;i<arr.Length;i++)
{
 if (arr[i]>0) sum++;
}
return sum;
}
 
 
void Main(string tx)
{
System.Console.Write(tx);
int m = Convert.ToInt32(Console.ReadLine());
if (m>0)
{
double[] vharr = new double[m];
vharr = VvodDan(m,"Введите любое чисело можно и отрицательное в ");
int sum0=SumNol(vharr);
System.Console.WriteLine($"Введенном вами масиве чисел ["+string.Join(", ", vharr)+$"] -> {sum0} чисел больше ноля");
}
else System.Console.WriteLine("Количество элементов массива не может быть менше или равно нулю, введите данные еще раз");
}

Main("Введите сколько чисел будет в массиве: ");

