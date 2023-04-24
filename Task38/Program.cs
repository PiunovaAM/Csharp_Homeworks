// Задача 38: 
// 1. Задайте массив вещественных чисел. 
// 2. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        double round = Math.Round(arr[i], 1);
        if (i < arr.Length - 1) Console.Write($"{round}, ");
        else Console.Write($"{round}");
    }
}

double DifMinMax(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    int i = 1;
    while (i < arr.Length)
    {
        if (max < arr[i])
            max = arr[i];
        if (min > arr[i])
            min = arr[i];
        i += 1;
    }
    return max - min;
}

double[] array = CreateArrayRndDouble(4, -99, 99);
Console.Write("[");
PrintArray(array);
Console.Write("] -> ");

Console.WriteLine("Difference between minimum and maximum number is " + Math.Round (DifMinMax(array), 1));

