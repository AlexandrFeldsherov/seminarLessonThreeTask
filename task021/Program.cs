/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

double DistanceBetweenPoints(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double dis1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return Math.Sqrt(Math.Pow(dis1, 2) + Math.Pow(z2 - z1, 2));
}
Console.WriteLine("Введите координы точки A");
Console.Write("X1 : ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Y1 : ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Z1 : ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координы точки B");
Console.Write("X2 : ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Y2 : ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Z2 : ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distanceBetweenPoints = DistanceBetweenPoints(x1, y1, z1, x2, y2, z2);
Console.WriteLine(Math.Round(distanceBetweenPoints,2));