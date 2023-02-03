// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.Write("Введите координат x1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координат y1: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координат z1: ");
int z1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координат x2: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координат y2: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координат z2: ");
int z2 = int.Parse(Console.ReadLine()!);

double x = Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2);
double c = Math.Sqrt(x);
Console.WriteLine(Math.Round(c, 2));