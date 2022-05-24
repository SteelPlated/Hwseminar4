/*Напишите программу, которая задаёт массив целых чисел 
и выводит их на экран.
Размер массива определяется пользователем.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

Console.WriteLine("Введите массив чисел через запятую");
string mas = Console.ReadLine(); //Считали массив в строку
int length_mas=mas.Length; //Запомнили длинну строки
int i=0; //Индекс для строки
int index=0; //Индекс для числового массива
int number=1; // Кол-во элементов числового массива
//Считаем, сколько будет чисел в массиве (с разделением ,)
while (i< length_mas)
    {
    if (mas[i]==',')
        number++;
    i++;
    }

//Создаем числовой массив с размером number
int[] array = new int[number];

//Запись элементов в числовой массив
    i=0;
    string a="0"; //число, которое будет записано в массив
    while (i<length_mas)
    {
       if (mas[i]!=',')
       {if (mas[i]!=' ')
            a=a+mas[i]; 
       }  
        else 
        {array[index]=Convert.ToInt32(a);
        index++;
        a="0";}
        i++;
            }

//Записываем последний элемент числового массива
        array[index]=Convert.ToInt32(a);
        
    // Вывод массива
    i=0;
    Console.Write($"Массив [");
    while (i< number)
    {
       Console.Write($"{array[i]}");
        if (i!=number-1)
             Console.Write(", "); 
        i++;
        }
    
       Console.WriteLine("]");
