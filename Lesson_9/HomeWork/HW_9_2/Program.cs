//  Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30

System.Console.Write("Введите первое число: ");
int A = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите второе число: ");
int B = int.Parse(Console.ReadLine()!);

int SumNum(int M, int N)
{
    if (N < M) return 0;
    return M + SumNum(M + 1, N);
}
 Console.Write(SumNum(A, B));