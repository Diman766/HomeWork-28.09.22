// Задача 66: 
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите значение M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N");
int n = Convert.ToInt32(Console.ReadLine());
if (m > n)
{
    Console.WriteLine("Число М должно быть меньше N !");
    return;
}

int PrintSumNumbers(int m, int n)
{
    if (m == n) return m;
    return (m + PrintSumNumbers(m + 1, n));
}

Console.WriteLine(PrintSumNumbers(m, n));