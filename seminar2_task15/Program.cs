// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число дня недели, проверьте это выходной: ");
int numDayofWeek = Convert.ToInt32(Console.ReadLine());
switch (numDayofWeek)
{
    case 1: Console.WriteLine("нет"); break;
    case 2: Console.WriteLine("нет"); break;
    case 3: Console.WriteLine("нет"); break;
    case 4: Console.WriteLine("нет"); break;
    case 5: Console.WriteLine("нет"); break;
    case 6: Console.WriteLine("да, это выходной"); break;
    case 7: Console.WriteLine("да, это выходной"); break;
    default: Console.WriteLine("это не день недели!"); break;
}
Console.WriteLine(numDayofWeek);
