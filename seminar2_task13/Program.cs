// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Пожалуйста, задайте любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 99 && num < 1000)
{
    int numresult = num%10;
    Console.WriteLine($"Третья цифра заданного числа: {numresult}");
}
else if (num > 999 && num < 10000)
{
    int numresult = (num%100)/10;
    Console.WriteLine($"Третья цифра заданного числа: {numresult}");
}
else if (num > 9999 && num < 100000)
{
    int numresult = (num%1000)/100;
    Console.WriteLine($"Третья цифра заданного числа: {numresult}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
