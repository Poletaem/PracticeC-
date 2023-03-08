// 3. Напишите программу, которая выводит массив из 8 элементов,
//    заполненный нулями и единицами в случайном порядке.

void massive(int mas)
{
    int[] numbers =  new int[mas];
    for (int i = 0; i < mas; i++)
    {
        numbers[i] = new Random().Next(2);
        Console.WriteLine(numbers[i]);
    }
}

massive(8);