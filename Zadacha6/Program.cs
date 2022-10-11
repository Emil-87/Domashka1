Console.WriteLine("Введите число а:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());

if (a * a == b || b * b == a)
{
    Console.WriteLine("Yes Это число является квадратом другого");
}
else
{
    Console.WriteLine("NO Ниодно число не является квадратом другого");
}