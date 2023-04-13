// Задача 10: 
// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа

Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 & number < 1000)
{
    int digit_2 = (number / 10) % 10;
    Console.WriteLine($"Second digit is {digit_2}");
}


