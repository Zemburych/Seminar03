// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B.
Console.Clear();
Console.Write("Ввелите число А - ");
int a = int.Parse(Console.ReadLine());
Console.Write("Ввелите число B - ");
int b = int.Parse(Console.ReadLine());

// int res = A;
// int i = 1;
// void degree(int A, int B)
// {
//     while (i<B)
//     {
//       res = res * A; 
//       i++;
//     }
// }
// return res;
// degree(A, B);
// Console.WriteLine(res);

double Pow(int a, int b)
{ 
  bool flag = b > 0;
  if (b < 0) b = -b;
  int res = 1;
  for (int i = 0; i < b; i++) res *=a;
  if (flag) return res;
  else return 1.0 / res;
}
Console.WriteLine("А в степени B = " + Pow(a, b));