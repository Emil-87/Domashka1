//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите день недели от 1 до 7");
int n = Convert.ToInt32(Console.ReadLine());
while ( n < 1 | n > 7)
{
    Console.WriteLine("В неделе 7 дней, введите заново");
    n = Convert.ToInt32(Console.ReadLine());
}
if
(n == 6| n == 7) Console.Write("Выходной");
else Console.WriteLine("Будни");