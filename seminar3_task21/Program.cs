// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Функция. Конвертация строкового значения в целочисленное.
int ImputNumber (string txt)
{
    Console.Write(txt);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = ImputNumber("Введите координаты точки x1: ");
int y1 = ImputNumber("Введите координаты точки y1: ");
int z1 = ImputNumber("Введите координаты точки z1: ");

int x2 = ImputNumber("Введите координаты точки x2: ");
int y2 = ImputNumber("Введите координаты точки y2: ");
int z2 = ImputNumber("Введите координаты точки z2: ");

double xyz = Math.Round(Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2)),2);
Console.WriteLine($"Расстояние между точками в 3d -> {xyz}");