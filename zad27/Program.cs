// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();
Console.Write("Ввелите число -  ");
int N = int.Parse(Console.ReadLine());
int summ = 0;
while (N > 0)
            {
                 summ = summ + N % 10;
                N = N / 10 ;
             }
 Console.WriteLine(summ);
