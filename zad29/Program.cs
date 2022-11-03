// Напишите программу, которая задаёт массив из N элементов и выводит их на экран
Console.Clear();
Console.WriteLine("Ввелите количество элементов массива  ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];
// Рандомный ввод массива
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
     {
      array[i] = rand.Next(1,9);
     }
//Вывод массива 
            Console.Write("Исходный массив - ");
            for (int i = 0; i < array.Length; i++)
            Console.Write(" " + array[i]);
            Console.WriteLine();
