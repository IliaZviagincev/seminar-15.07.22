// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите X первой точки:  ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите Y первой точки:  ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите Z первой точки:  ");
double z1 = double.Parse(Console.ReadLine());

Console.Write("Введите X второй точки:  ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите Y второй точки:  ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Введите Z второй точки:  ");
double z2 = double.Parse(Console.ReadLine());

double getDiff(double num1, double num2)
{
    double result = Math.Pow(num2 - num1, 2);
    return result;
}

double coord = Math.Sqrt(getDiff(x1, x2) + getDiff(y1, y2) + getDiff(z1, z2));
Console.WriteLine(Math.Round(coord, 2));