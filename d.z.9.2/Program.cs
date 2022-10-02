// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
//  натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Введите число M");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int b = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма ({a},{b}) = {SumMN(a - 1, b)}");

int SumMN(int a, int b)
{
    int result = a;
    if (a == b)
        return 0;
    else
    {
        a++;
        result = a + SumMN(a, b);
        return result;
    }
}
