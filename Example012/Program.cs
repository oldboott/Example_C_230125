// Написать программу которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа
// 456 > 6

Console.Clear();

Console.Write("Введите трехзначное число: ");
int N = int.Parse(Console.ReadLine()!);

int number = N % 10;
Console.WriteLine($"Последняя цифра числа {N} — {number}");



