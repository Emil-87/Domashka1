// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число:");
int a = int.Parse(Console.ReadLine());
a = Math.Abs(a);
if (a >= 100)
   {
        if (a > 999)
           {
           int i = 10;
           while (a / i > 1000)
               {
                 i = i * 10;
               }
             Console.WriteLine("Третья цифра числа -" + (a / i) % 10);
            }
        else
            {
             Console.WriteLine(" Третья цифра числа -" + a % 10);
            }
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
