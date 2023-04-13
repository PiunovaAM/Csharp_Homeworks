// Задача 15:
// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

void CheckDay (int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
        Console.WriteLine("This day is day off!");
    else Console.WriteLine("This day isn't a holiday");
}

Console.Write("Input number representing the day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
CheckDay(dayNumber);

// Можно добавить еще условие на проверку является ли этот день вообще днем недели
/*
void CheckDay (int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
        Console.WriteLine("This day is day off!");
    else if(dayNumber < 1 || dayNumber > 7)
        Console.WriteLine("This is not the day of the week!");
    else Console.WriteLine("This day isn't a holiday");
}

Console.Write("Input number representing the day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
CheckDay(dayNumber);
*/

