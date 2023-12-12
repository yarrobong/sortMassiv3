using System;

class Program
{
    static void Main()
    {
        int[] A = { 3, -2, 4, 0, -6, 7, -1, 8, -5, 9 };

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] < 0)
            {
                A[i] *= A[i]; 
            }
            else if (A[i] > 0)
            {
                A[i] /= 2; 
            }
        }

        Array.Sort(A);

        Console.WriteLine("Преобразованный и отсортированный массив:");
        foreach (int element in A)
        {
            Console.Write(element + " ");
        }
    }
}