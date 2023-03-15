//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3




    Console.Write("Введите количество чисел:");
    int count = int.Parse(Console.ReadLine()!);
    int[] Array = new int[count];

void  FillMass(int count)
{

    for (int i = 0; i < count; i++)
    {
        Console.Write($"Введите числа:    ");
        Array[i] = int.Parse(Console.ReadLine()!);
      
    }
              
}       

FillMass(count);
Console.WriteLine();

int AmtMass(int[] Array)

{
    int amt = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > 0)
            amt += 1;
    }
    return amt;
}

int result = AmtMass(Array);
Console.WriteLine($"Количество чисел больше 0 = {result}" );

