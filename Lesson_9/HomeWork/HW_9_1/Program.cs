//  Задайте значения M и N. Напишите программу, которая выведет все чётные
//натуральные числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"

System.Console.Write("Введите первое число: ");
int A = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите второе число: ");
int B = int.Parse(Console.ReadLine()!);

void EvenNums(int M, int N)
{
    if (N < M) return;
    else if (N % 2 != 0)
    {
        N = N - 1;
        EvenNums(M, N - 2);
    }
    else
        EvenNums(M, N - 2);
        System.Console.Write($"{N}, ");
}
EvenNums(A, B);