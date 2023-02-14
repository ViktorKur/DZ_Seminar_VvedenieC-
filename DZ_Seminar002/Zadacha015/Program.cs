// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
System.Console.Write("Введите цифрой день недели (от 1 до 7), а программа проверит является ли этот день выходным: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day<1 || day>7)
{
  System.Console.WriteLine("Не допустимое цифровое обозначение дня недели");
  return;
}
else if (day>0 && day<6)
{
  System.Console.WriteLine($" {day} -> нет не выходной день");
  return;
}
else if (day>5 && day<8)
{
  System.Console.WriteLine($" {day} -> да этот день выходной");
  return;
}

// switch (day)
// {
//   case 1:
//   {
//     System.Console.WriteLine("Понедельник -> нет не выходной");
//     break;
//   }
// case 2:
//   {
//     System.Console.WriteLine("Вторник -> нет не выходной");
//     break;
//   }
// case 3:
//   {
//     System.Console.WriteLine("Среда -> нет не выходной");
//     break;
//   }
// case 4:
//   {
//     System.Console.WriteLine("Четверг -> нет не выходной");
//         break;
//   }
// case 5:
//   {
//     System.Console.WriteLine("Пятница -> нет не выходной");
//     break;
//   }
// case 6:
//   {
//     System.Console.WriteLine("Суббота -> да это выходной");
//     break;
//   }
// case 7:
//   {
//     System.Console.WriteLine("Воскресенье -> да это выходной");
//     break;
//   }


// }