// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double DistanceAB(int xa, int ya, int za, int xb, int yb, int zb)
{
    int deltaX = xa - xb;
    int deltaY = ya - yb;
    int deltaZ = za - zb;
    double distAB = Math.Round(Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ), 2);   
    return distAB;
}
Console.Write("Input X coordinate of A: ");
int xACoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Input X coordinate of B: ");
int xBCoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Y coordinate of A: ");
int yACoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Y coordinate of B: ");
int yBCoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Z coordinate of A: ");
int zACoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Z coordinate of B: ");
int zBCoord = Convert.ToInt32(Console.ReadLine());

double distanceAB = DistanceAB(xACoord, yACoord, zACoord, xBCoord, yBCoord, zBCoord);

Console.WriteLine($"Distance between A and B is {distanceAB}");