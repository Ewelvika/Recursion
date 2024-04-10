using System;

class Program
{
    static void Main()
    {
        int[] array_0 = { 198, 265, 3, 4567, 3, 4326, 1, -7, 56 };
        ReverseArrayWithRecursion(array_0, array_0.Length - 1);
    }

    static void ReverseArrayWithRecursion(int[] array_1, int index_1)
    {
        if (index_1 >= 0)
        {
            Console.Write(array_1[index_1] + " ");
            ReverseArrayWithRecursion(array_1, index_1 - 1);
        }
    }
}
