// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.Write("Введите количество строк 1 массива: ");
// int rowsA = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов 1 массива: ");
// int columnsA = int.Parse(Console.ReadLine());
// Console.Write("Введите количество строк 2 массива: ");
// int rowsB = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов 2 массива: ");
// int columnsB = int.Parse(Console.ReadLine());
// if (columnsA != rowsB)
// {
//     Console.WriteLine("Такие матрицы умножать нельзя!");
//     return;
// }
// int[,] A = GetArray(rowsA, columnsA, 0, 10);
// int[,] B = GetArray(rowsB, columnsB, 0, 10);
// PrintArray(A);
// Console.WriteLine();
// PrintArray(B);
// Console.WriteLine();
// PrintArray(GetMultiplicationMatrix(A, B));

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }

//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB)
// {
//     int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
//     for (int i = 0; i < arrayA.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayB.GetLength(1); j++)
//         {
//             for (int k = 0; k < arrayA.GetLength(1); k++)
//             {
//                 arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
//             }
//         }
//     }
//     return arrayC;
// }

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine();
    }
}

bool AgreedMatrix(int[,] matrixA, int[,] matrixB) //согласование матриц 
{
    if (matrixA.GetLength(1) == matrixB.GetLength(0)) return true;
    else return false;
}


int[,] MultiplyMatrix(int[,] arr2dA, int[,] arr2dB)
{

    int[,] arr2dC = new int[arr2dA.GetLength(0), arr2dB.GetLength(1)];
    for (int i = 0; i < arr2dC.GetLength(0); i++)
    {
        for (int j = 0; j < arr2dC.GetLength(1); j++)
        {
            for (int n = 0; n < arr2dB.GetLength(0); n++)
            {
                arr2dC[i, j] = arr2dC[i, j] + arr2dA[i, n] * arr2dB[n, j];
            }
        }
    }
    return arr2dC;

}

int[,] matrixA = CreateMatrixRndInt(2, 2, 2, 5);
Console.WriteLine("Матрица А: ");
PrintMatrix(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица В: ");
int[,] matrixB = CreateMatrixRndInt(2, 2, 2, 5);
PrintMatrix(matrixB);
Console.WriteLine();
if (AgreedMatrix(matrixA, matrixB))
{
    int[,] multiplyMatrix = MultiplyMatrix(matrixA, matrixB);
    Console.WriteLine("Результирующая матрица С: ");
    PrintMatrix(multiplyMatrix);
}
else
{
    Console.WriteLine("Матрицы не согласовны, умножение не возможно!");
}
Console.WriteLine();





