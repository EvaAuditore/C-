// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Clear();
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

int Method(int num)
{
    int count = 0;
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        Console.WriteLine(sum);
        num = num / 10;
        //Console.WriteLine(num);
        count++;
        Console.WriteLine(num);
    }
    return sum;
}
Console.WriteLine($"{number} - > {Method(number)}");