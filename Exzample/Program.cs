﻿// Для решения разных задач

// На вход программы вводят два числа, сравнить какое больше или меньше, вывести результат

// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.


Console.Clear ();
Console.WriteLine("Введите число и нажмите клавишу Enter");

int N = int.Parse(Console.ReadLine()!);

int k = 1;
while(k<=N)
{
    if (k%2==0)
    Console.Write($"{k} ");
    k++;
}