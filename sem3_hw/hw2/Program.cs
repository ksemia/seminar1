// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// есть две точки с координатами A (x 1 , y 1, z 1 ) и B (x 2 , y 2, z 2 )
// формула расстояния (теорема Пифагора) =  корень из выражения: {(x2-x1) ^{2} + (y2-y1) ^{2} + (z2-z1) ^{2}}, ^{2} это () в квадрате. 
// {(2-3)}^{2}+(1-6)^{2}+(-7-8)^{2} = 251 = примерно 15,85

using static System.Console;
Write("введите x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Write("введите y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Write("введите z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Write("введите x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Write("введите y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Write("введите z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double c=Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2));
Console.WriteLine(c);