// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// // Приглашение ко вводу
// // Перевод строковых в целочисленные
// Console.Write("Пожалуйста, введите число N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// // Создана новая переменная
// int num1 = 2;
// // Создана пустая строка
// string result = string.Empty;
// // Накапливание результата с помощью оператора while, значения увеличиваются на 2
// while (num > num1)
// {
//     result = result + num1 + " ";
//     num1 = num1 + 2;
// }
// // Проверка на четность и необходимость включения введенного числа
// // Вывод строки в консоль
// if (num % 2 == 0)
// {
//     result = result + num;
//     Console.WriteLine("Все четные числа от 1 до N: " + result);
// }
// else
// {
//     Console.WriteLine("Все четные числа от 1 до N: " + result);
// }

Console.Write("Пожалуйста, введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 1;
while(num1<=num)
{
    if(num1%2==0)
    Console.Write(num1+", ");
    num1++;
}

