Console.WriteLine("введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите число 2: ");
int number2 = int.Parse(Console.ReadLine());
if (number2 == number1*number1)
  {
    Console.WriteLine($"{number2} является квадратом {number1}");
  }
else
  {
    Console.WriteLine($"{number2} НЕ является квадратом {number1}");
  }
