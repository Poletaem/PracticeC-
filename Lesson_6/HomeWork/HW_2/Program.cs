// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void Point(double B1, double K1, double B2, double K2)

{
Console.WriteLine("введите значение b1");
double b1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("введите число k1");
double k1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("введите значение b2");
double b2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("введите число k2");
double k2 = int.Parse(Console.ReadLine()!);

double x = (b2 - b1) / (k1 - k2);
double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;


    if ((k1 == k2) && (b1 == b2))
    {
        Console.WriteLine("Прямые совпадают");
    }
    else if (k1 == k2)
    {
       Console.WriteLine("Прямые параллельны");
    }
    else
    {
        Console.WriteLine($"Прямые пересекутся в точке с координатами X: {x}, Y: {y}");
    }
}

Point(b1, k1, b2, k2);