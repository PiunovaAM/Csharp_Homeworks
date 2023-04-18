// Задача 25: Н
// 1. Напишите цикл, который принимает на вход два числа (A и B) 
// 2. и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (CheckExpo (numberB))
{
    Console.Write($"Число {numberA} в степени {numberB} равно {Exponent (numberA, numberB)}");
}

int Exponent(int numA, int numB)
{
    int expo = 1;
    for (int i = 0; i < numB; i++)
    {
        expo *= numA;
    }
    return expo;
}

bool CheckExpo (int numB)
{
    if ( numB < 0)
    {
        Console.Write ("Число не должно быть меньше нуля");
        return false;
    }
    return true;
}