using System;

class Program
{
    static void Main()
    {
        int M = -56;
        int N = 437; 

        if (M >= N) 
        {
            Console.Write("Неправильное условие") ;
        }
        else NaturalNumbers(M, N);
    }

    static void NaturalNumbers(int current, int N)
    {
        if (current <= N)
        {
            if (current > 0)
            {
                Console.Write(current + " ");
            }
            
            NaturalNumbers(current + 1, N);
        }
    }
}