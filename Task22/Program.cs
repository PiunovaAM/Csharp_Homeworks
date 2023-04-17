void TableSquare(int num)
{
    int count = 1;
    while (count <= num )
    {
        Console.WriteLine($"{count}  {count * count}");
        count+=1;
    }
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
TableSquare(number);
