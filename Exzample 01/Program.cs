/* Задача 4. Напишите программу, которая на вход принимает три числа и выдает максимальное из этих чисел
    Например,   а=2, в=3, c=7 -> max=7
                а=44, в=5 c=78 -> max=78
                а=22, в=3 c=9 -> max=22
*/ 

Console.Clear();

Console.WriteLine("Введите число А и нажмите клавишу Enter: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число В и нажмите клавишу Enter: ");

int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число C и нажмите клавишу Enter: ");

int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (a > max) max = a;

if (b > max) max = b;

if (c > max) max = c;

Console.WriteLine($"Максимальное число {max} ");