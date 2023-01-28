// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();

Console.Write("Введите первое число: ");
int FirstNum = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int SecondNum = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число: ");
int ThirdNum = int.Parse(Console.ReadLine()!);

int max = FirstNum;

if (SecondNum > max) max = SecondNum;
if (ThirdNum > max) max = ThirdNum;

Console.WriteLine($"Максимальное число: {max}");



