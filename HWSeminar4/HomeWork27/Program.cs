/*Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

 int count = Convert.ToString(num).Length;
    int sum = 0;

    for (int i = 0; i < count; i++)
    {
      sum = sum + num % 10;
      num = num / 10;
    }
 
Console.WriteLine("Сумма цифр в числе: " + sum);
