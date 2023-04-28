// Задача 41: 
// 1. Пользователь вводит с клавиатуры M чисел. 
// 2. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
 
int NumsMoreThanZero(int[] arr)
{
    int i = 0;
    int res = 0;
    while (i < arr.Length)
    {
        if (arr[i] > 0)
        {
            res += 1;
        }
        i += 1;
    }
    return res;
}

Console.WriteLine("Number of symbols greater than zero is " + NumsMoreThanZero(arr));



// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
// }

// int NumsMoreZero(int[] arr)
// {
//     int i = 0;
//     int res = 0;
//     while (i < arr.Length)
//     {
//         if (arr[i] > 0)
//         {
//             res += 1;
//         }
//         i += 1;
//     }
//     return res;
// }


// int[] array = CreateArrayRndInt(12, -9, 9);
// Console.Write("[");
// PrintArray(array);
// Console.Write("]");
// Console.WriteLine();

// Console.WriteLine("Number of symbols greater than zero are " + NumsMoreZero(array));