/*Напишите программу, которая задаёт массив целых чисел 
и выводит их на экран.
Размер массива определяется пользователем.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

Console.Write("Введите размер массива: ");
int number = int.Parse(Console.ReadLine());
int[] array = new int[number];
int index=0;

    Console.Write($"Массив [");
    while (index< number)
    {
        array[index] = new Random().Next(0, 100);
        Console.Write($"{array[index]}");
        if (index!=number-1)
             Console.Write(", "); 
        index++;
        }
    
       Console.WriteLine("]");
