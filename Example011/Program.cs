// Написать программу которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N
// 4 > -4, -3, -2, -1, 0, 1, 2, 3, 4


Console.Clear();
Console.WriteLine("Введите число: ");

int number = int.Parse(Console.ReadLine()!);
int number1 = -number;

while(number1<=number)
{
    Console.Write($"{number1}, ");
    number1++;
}


