// Задача 27: Напишите программу, 
// 1. которая принимает на вход число и 
// 2. выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

Console.Write($"Сумма всех цифр в числе {userNumber} -> {SummOfDigits(userNumber)}");

int SummOfDigits (int num)
{
    int result = 0;
    while ( num != 0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}