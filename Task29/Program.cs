// Задача 29: Напишите программу, которая
// 1. задаёт массив из 8 элементов и 
// 2. выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


Console.Write("Введите длину массива: ");
int lenghtArray = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(lenghtArray);
PrintArray(arr);

int[] CreateArray(int size)
{
    int[] array = new int [size];
    Random random = new Random(); // оптимизация объекта Random (var - объект неявной типизации)
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length -1]}");
    Console.WriteLine("]");
}