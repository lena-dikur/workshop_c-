// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Вариант 1
// Console.WriteLine("Пожалуйста, введите первое число");
// int numbera = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Пожалуйста, введите второе число");
// int numberb = Convert.ToInt32(Console.ReadLine());

// if (numbera > numberb)
// {
//     Console.WriteLine("Максимальное число: " + numbera);
// }
// if (numberb > numbera)
// {
//     Console.WriteLine("Максимальное число: " + numberb);
// }

// Вариант 2
// Приглашение ко вводу
// Считывание данных из консоли
Console.Write("Введите первое число: ");
string? imputnum1 = Console.ReadLine();
Console.Write("Введите второе число: ");
string? imputnum2 = Console.ReadLine();
// Проверка, что значения не пустые
if ((imputnum1 != null) && (imputnum2 != null))
// Перевод строковых в целочисленные, с помощью оператора Parse
{
    int numberA = int.Parse(imputnum1);
    int numberB = int.Parse(imputnum2);
// Вычисления
// Вывод результата
    if (numberA > numberB)
    {
        Console.WriteLine("Первое число больше второго ");
    }
    else
    {
        Console.WriteLine("Первое число меньше второго");
    }
}