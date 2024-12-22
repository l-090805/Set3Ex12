using System;
namespace Set3Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("introdu un sir de numere: ");
            string input = Console.ReadLine();
            int[] v = Array.ConvertAll(input.Split(' '), int.Parse);

            Console.WriteLine("Vector inainte de sortare:");
            PrintArray(v);

            SelectionSort(v);

            Console.WriteLine("Vector dupa selection sort:");
            PrintArray(v);

            
        }

        static void SelectionSort(int[] v)
        {
            int n = v.Length;   

            for(int i = 0; i < n-1; i++)
            {
                int minim = i;

                for(int j = i + 1;  j < n; j++)
                {
                    if(v[j] < v[minim])
                    {
                        minim = j;
                    }
                }

                if(minim != i)
                {
                    Swap(v,i,minim);
                }

                Console.WriteLine($"Pasul {i+1}: ");
                PrintArray(v);
            }

        }
            static void Swap (int[] v, int i, int j)
            {
                int temp = v[i];
                v[i] = v[j];
                v[j] = temp;
            }

            static void PrintArray (int[] v)
            {
                foreach(int item in v)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
    }
}
