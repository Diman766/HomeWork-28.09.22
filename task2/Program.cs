// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> Akkerman(m,n) = 9
// m = 3, n = 2 -> Akkerman(m,n) = 29

Console.WriteLine("Введите значение M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)
{
    if (n == 0) return m + 1;
    if (n > 0 && m == 0) return Akkerman(n - 1, 1);
    if (n > 0 && m > 0) return Akkerman(n - 1, Akkerman(n, m - 1));
    return Akkerman(n, m);
}
Console.WriteLine(Akkerman(m, n));