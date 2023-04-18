// Задача 13:
// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
/*
Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 & number < 1000)
{
    int digit_3 = number % 10;
    Console.WriteLine($"Third digit is {digit_3}");
}
else
{
    Console.WriteLine("Your number isn't 3-digit!");
}
*/
/*
Console.Write("Input your number: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);

if (anyNumberText.Length > 2)
{
  Console.WriteLine("Third digit is -> " + anyNumberText[2]);
}
else 
{
  Console.WriteLine("Your number isn't 3-digit!");
}
*/

int ThirdDigit (int num)
{
    int count = num;
    while (num > 999)
    {
        num = num / 10;
        count++;
    }
        return num % 10;
}

Console.WriteLine("Введите любое число больше 99: ");
int number = Convert.ToInt32(Console.ReadLine());

string res = (number >= 100) ? $"третья цифра: {ThirdDigit(number)}" : "третьей цифры нет";
Console.WriteLine(res);