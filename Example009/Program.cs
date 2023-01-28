// Написать программу которая на вход принимает два числа и проверяет является ли первое число квадратом второго
// а = 25, б = 5 > да

Console.Clear();
Console.WriteLine ("Введите число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number2 * number2 == number1)
{
Console.WriteLine($"{number1} является квадратом {number2}");
}
else
{
    Console.WriteLine($"{number1} не является квадратом {number2}");
}

