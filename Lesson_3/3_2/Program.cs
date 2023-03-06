// 2. Напишите программу, которая принимает на вход координаты
//    двух точек и находит расстояние между ними в 2D пространстве.
//    https://ru.onlinemschool.com/math/library/analytic_geometry/point_point_length/


//AB = √(xb - xa)2 + (yb - ya)2;

double dis(double x1, double y1, double x2 , double y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));
}
Console.WriteLine(dis(3, 6, 2, 1));