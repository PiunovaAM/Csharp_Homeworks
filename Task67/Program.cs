﻿// Решение с рекурсией для нахождения факториала
// int FactorialRec(int n)
//  {
//      if (n == 1) return 1;
//      return n * FactorialRec(n - 1);
//  }

//  Console.WriteLine(FactorialRec(10));

// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.WriteLine("Введите целое натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigits = SumDigits(number);
Console.WriteLine(sumDigits);

int SumDigits(int num)
{
    if (num == 0) return 0;
    else return num % 10 + SumDigits(num / 10); // return num == 0 ? 0 : num % 10 + SumDigits(num / 10);
}