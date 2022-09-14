// задача, решённая на семинаре.
// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

// Console.Write ("Введите значение М:  ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Введите значение N:  ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (M > N)
// {
//     return;
// }
// String PrintNumbers (int start, int end)
// {
// if (start == end)
// {
//     return start.ToString();
// }
// return(start + "," + PrintNumbers(start +1, end));
// }
// Console.WriteLine ($"Числа от {M} до {N}:  '{PrintNumbers (M,N)}' ");

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write ("Введите значение М:  ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Введите значение N:  ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (M > N)
// {
//     return;
// }
// int PrintNumbers (int start, int end)
// {
// if (start == end)
// {
//     return start;
// }
// return(start + PrintNumbers (start+1, end));
// }
// Console.WriteLine ($"Сумма чисел от {M} до {N} = {PrintNumbers (M,N)} ");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.Write("Введите значение m:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n:  ");
int n = Convert.ToInt32(Console.ReadLine());
if (m < 0 || n < 0)
{
    return;
}
static int recursion(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return recursion(m - 1, 1);
    }
    else
    {
        return recursion(m - 1, recursion(m, n - 1));
    }
}
Console.Write($" А({m},{n}) = {recursion(m, n)}");



