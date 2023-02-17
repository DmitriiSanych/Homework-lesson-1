/* Задача 2. Напишите программу, которая на вход принимает два числа и выдает какое число большее, а какое меньшее
    Например,   а=5, в=7 -> max=7
                а=2, в=10 -> max=10
                а=-9, в=-3 -> max=-3
*/ 

Console.Clear();

Console.WriteLine("Введите число и нажмите клавишу Enter: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число и нажмите клавишу Enter: ");

int b = Convert.ToInt32(Console.ReadLine());

if (b == a)
{
    Console.WriteLine($" числа равны");   
}   
if (a > b)
{
    Console.WriteLine($" число {a} больше числа {b}");
}
if (b > a)
{
    Console.WriteLine($" число {b} больше числа {a}");
}
