//вводим трехзначное число, на выходе третья цифра числа

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if (number >=100 && number < 1000)
{
    Console.WriteLine(number % 10);
}
else 
{
    Console.WriteLine("Введите верное значение");
}