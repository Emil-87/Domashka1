//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = 0;
Console.WriteLine("Введите трех значное число");
number = Convert.ToInt32(Console.ReadLine());
if(number >=100 && number <= 999)
{
    int DecreaseByTen= number / 10;
    int LastDigit = DecreaseByTen % 10;
    Console.WriteLine("Вторая цифра числа =" +LastDigit);
}
else
{
    Console.WriteLine("Это не трехзначное число");
}