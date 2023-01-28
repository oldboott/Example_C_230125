// Найти квадрат числа

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int sqr = number * number;
Console.WriteLine($"Квадрат числа {number} равен {sqr}");