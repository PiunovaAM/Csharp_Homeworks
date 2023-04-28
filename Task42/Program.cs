﻿// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// решение с помощью int
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Convert10to2(int num)
{
   int result = 0;
   int i = 1;
   while (num>0)
   {
      result+=(num % 2)*i;
      num /= 2;
      i*=10;
   }
   return result;
}
int convert10to2 = Convert10to2(number);
Console.WriteLine(convert10to2);

// решение с помощью string

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Convert10to2Int(int num)
{
   int result = 0;
   int i = 1;
   while (num > 0)
   {
      result += (num % 2) * i;
      num /= 2;
      i *= 10;
   }
   return result;
}
string Convert10to2String(int num)
{
   string result = string.Empty;
   while (num > 0)
   {
      result = num % 2 + result;
      num /= 2;
   }
   return result;
}

// int convert10to2int = Convert10to2Int(number);
// Console.WriteLine(convert10to2int);
Console.WriteLine();
string convert10to2String = Convert10to2String(number);
// for (int i = 0; i < convert10to2String.Length; i++)
// {
//    Console.Write(convert10to2String[convert10to2String.Length - 1 - i]);
// }

Console.WriteLine(convert10to2String);
