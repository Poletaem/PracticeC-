// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Prod(int A, int B)

{
    int pov = 1;

    for(int i = 1; i <= B; i++)
    pov = pov * A;

    return pov;
}

Console.WriteLine("Введите числа: ");
int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);

int result =  Prod(A, B);
Console.WriteLine(result);
