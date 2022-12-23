/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
    Даны два неотрицательных числа m и n.
    m = 2, n = 3 -> A(m,n) = 9
    m = 3, n = 2 -> A(m,n) = 29 */

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FunAkk(M, N));

int FunAkk(int N, int M)
{
    if (N == 0) return M + 1;
    if ((N != 0) && (M == 0))
        return FunAkk(N - 1, 1);
    return FunAkk(N - 1, FunAkk(N, M - 1));
}









