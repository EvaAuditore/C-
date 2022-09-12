// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите первое число:");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number2 = int.Parse(Console.ReadLine());

int Method(int num1, int num2)
{
    int count = 1;
    int result = 1;
    while (count <= num2)
    {
        result *= num1; //result = result * num1;
        //Console.WriteLine(result);
        count++;
    }
    return result;
}
Console.WriteLine($"{number},{number2} - > {Method(number,number2)}");