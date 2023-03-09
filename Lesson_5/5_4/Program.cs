// 4. Найдите произведение пар чисел в одномерном массиве.
//    Парой считаем первый и последний элемент, второй и предпоследний
//    и т.д. Результат запишите в новом массиве.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

// void MultiMas(int[] arr){
//     int mult = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         for (int j = arr.Length-1; j > 0; j--){
//             mult = arr[i]*arr[j];
//             Console.WriteLine($"{arr[i]} x {arr[j]} = {mult}");
//         }
//     }

//     //Переделаю, под диктовку)
// }

int[] MultiMas(int[] arr){
    int size = arr.Length;
    int[] newMass = new int[size/2 + size%2];
    for (int i = 0; i < size/2; i++)
    {
        newMass[i] = arr[i]*arr[size-1-i];
    }
    if (size%2 == 1){
        newMass[newMass.Length-1] = arr[arr.Length/2];    
    }
    return newMass;
}

Console.WriteLine("Введите размер массива");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Диапазон от");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Диапазон до");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);

int[] newNewMass = MultiMas(mass);
Print(newNewMass); 