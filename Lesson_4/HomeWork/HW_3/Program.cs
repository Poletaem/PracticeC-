//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

//Код работает, как сделать из этого функию я не понимаю(



{
Console.Write("Введите количество элементов массива:");
int count = int.Parse(Console.ReadLine()!);
int[] Array  = new int[count];

    for (int i = 0; i < Array.Length; i++)
    {
       Console.Write($"Введите элементы массива:    ");
       Array[i] =  int.Parse(Console.ReadLine()!);
      
    }

    for( int i =0; i < Array.Length; i++)
   
    Console.Write($"{Array[i]} "); //Мария, почему если это написать в 16 строке и убрать здесь цикл вся магия перестает работать?))
}



