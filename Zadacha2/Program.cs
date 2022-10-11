//Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите четверть");
int z = Convert.ToInt32(Console.ReadLine());
if (z > 0 && z < 5)
{
    if (z == 1)
    {
        Console.WriteLine("Диапазон X 1-4 Диапазон Y 1-4");
    }
    if (z == 2)
    {
        Console.WriteLine("Диапазон X 1-4 Диапазон Y -4 - -1");
    }
    if (z == 3)
    {
        Console.WriteLine("Диапазон X -4 - -1 Диапазон Y -4 - -1");
    }
    if (z == 4)
    {
        Console.WriteLine("Диапазон X 1-4 Диапазон Y -4 - -1");
    }
}
else {
    Console.WriteLine("Ошибка диапазона");
}
