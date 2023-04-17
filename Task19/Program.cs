// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrome (string number)
{
    if (number [0] == number [4] && number [1] == number [3])
    {
        Console.Write($"Your {number} is palindrome");
    }
    else Console.Write($"Your {number} isn't palindrome");
}

Console.Write("Input your five-digit number: ");
string? number = Console.ReadLine();

if (number!.Length == 5)
{
    Palindrome(number);
}
else Console.WriteLine($"Input right number");

// или
/*
void Palindrome (int number)
{
    if(number%10 != number/10%10 & number%10 != number/100%10 & number/10%10 != number/100%10)
    {
        Console.Write($"{number} is palindrome");
    }
    else Console.Write($"{number} is NOT palindrome");
}
Console.Write("Input your five-digit number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number > 10000 & user_number < 100000)
{
    Palindrome(user_number);
}
else Console.WriteLine("Input five-digit number");
*/