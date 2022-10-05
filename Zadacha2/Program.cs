Console.Write("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > a) max = b;
Console.WriteLine(max);

// Задача 2.   Написать программу которая при входе имеет 2 числа, и найти мин. и макс.
// a = 5 b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3