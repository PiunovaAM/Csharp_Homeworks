//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

void Cubes(int uN)
{
    int current = 1; // ввели перменную, которую будем возводить в куб
    while (current <= uN) //ограничили условием, что переменная не должна превышать user number (uN)
    {
        int res = current * current * current; // ввели доп.переменную, которая считает куб
        Console.Write($"{res}, ");
        current++; // повторяем цикл до завершения (current +1)
    }
    Console.WriteLine("\b\b.");
}
Console.Write("Input number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number >= 1)
{
    Console.Write($"{user_number} -> ");
    Cubes(user_number);
}
else Console.Write("Impossible value!");
