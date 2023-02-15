// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.Write("Введите ПЯТИЗНАЧНОЕ число -> ");
string? num = Console.ReadLine();
int L = num!.Length;

if (L==5)
{
    if(num[0]==num[4]&&num[1]==num[3])
    {
        System.Console.WriteLine($"{num} ПАЛИНДРОМ");
    }
    else
    {
        System.Console.WriteLine($"{num} НЕ ПАЛИНДРОМ");
    }
}
else
{
    System.Console.WriteLine($"{num} НЕ ПЯТИЗНАЧНОЕ число");
}