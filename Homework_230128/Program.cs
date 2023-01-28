// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.Clear();

Console.Write("Введите первое число: ");
int FirstNum = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int SecondNum = int.Parse(Console.ReadLine()!);

if (FirstNum > SecondNum)
{
    Console.WriteLine($"Большее число {FirstNum}, меньшее число {SecondNum}");
}

else Console.WriteLine($"Большее число {SecondNum}, меньшее число {FirstNum}");

