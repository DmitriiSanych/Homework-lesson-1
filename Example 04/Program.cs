/* Задача 8. Напишите программу, которая на вход принимает число N, а на выходе показывает все чётные числа от 1 до N.
  Например,     N=5 -> 2, 4
                N=8 -> 2, 4, 6, 8
*/ 


Console.Clear ();
Console.WriteLine("Введите число и нажмите клавишу Enter");

int N = int.Parse(Console.ReadLine()!);

int k = 1;
while(k<=N)
{
    if (k%2==0)
      Console.Write($" {k} ");
      k++;
}