// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату X первой точки:");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки:");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату X второй точки:");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки:");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine(Math.Sqrt((Math.Pow((x2-x1), 2)+Math.Pow((y2-y1), 2))));
