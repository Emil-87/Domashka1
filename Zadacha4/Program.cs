Console.WriteLine("Ввидите число");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 99)
{
    Console.WriteLine((n / 100) %10);
}
else
{
    Console.WriteLine("Здесь нет третьей цифры");
}


