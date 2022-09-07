// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти:");
int number = int.Parse(Console.ReadLine());
if(number == 1)
{
    Console.WriteLine("Возможные точки для х от 1 до n, y от 1 до n");
}
if(number == 2)
{
    Console.WriteLine("Возможные точки для х от -1 до -n, y от 1 до n");
}
if(number == 3)
{
    Console.WriteLine("Возможные точки для х от -1 до -n, y от -1 до -n");
}
if(number == 4)
{
    Console.WriteLine("Возможные точки для х от 1 до n, y от -1 до -n");
}