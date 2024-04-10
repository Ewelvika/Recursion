/*Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.*/

using System;

class AckermanFunction
{
    static int Ackerman(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackerman(m - 1, 1);
        }
        else
        {
            return Ackerman(m - 1, Ackerman(m, n - 1));
        }
    }

    static void Main()
    {
        int m = 3;
        int n = 2;

        if (m >= 0 && n >= 0)
        {
            int result = Ackerman(m, n);
            Console.WriteLine($"Функция Акермана({m}, {n}) = {result}");
        }
        else
        {
            Console.WriteLine("Неверное условие");
        }
    }
}
