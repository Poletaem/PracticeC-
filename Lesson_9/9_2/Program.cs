// 2. Задайте значения M и N. Напишите программу, которая 
//    рекурсивно выведет все натуральные числа в промежутке от M до N.

void NumsFromTo(int M, int N)
{
    if (M == N + 1) return;
    NumsFromTo(M, N - 1);
    System.Console.Write($"{N}, ");
}
System.Console.Write("Введите первое число: ");
int Num = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите второе число: ");
int Num2 = int.Parse(Console.ReadLine()!);


NumsFromTo(Num, Num2); 