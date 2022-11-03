// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B.
Console.Clear();
Console.Write("Ввелите число А - ");
int A = int.Parse(Console.ReadLine());
Console.Write("Ввелите число B - ");
int B = int.Parse(Console.ReadLine());

int res = A;
int i = 1;
void degree(int A, int B)
{
    while (i<B)
    {
      res = res * A; 
      i++;
    }
}
return res;
degree(A, B);
Console.WriteLine(res);
