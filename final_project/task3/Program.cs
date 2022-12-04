// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// Функция Аккермана — простой пример всюду определённой вычислимой функции, 
// которая не является примитивно рекурсивной. 
// Она принимает два неотрицательных целых числа в качестве параметров и возвращает натуральное число, 
// определяется как: А(m,n) = n+1; A(m-1,1); A(m-1,A(m,n-1)), проверить что числа неотрицательные!

using static System.Console;
Clear();

Console.WriteLine ("задайте число m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine ("задайте число n: ");
int n = int.Parse(Console.ReadLine());

int Akkermann (int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Akkermann(m - 1, 1);
    if (m > 0 && n > 0) return Akkermann(m - 1, Akkermann(m, n - 1));
    return Akkermann(m, n);
}
Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {Akkermann(m, n)}");