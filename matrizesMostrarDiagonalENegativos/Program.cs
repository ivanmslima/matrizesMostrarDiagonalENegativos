using System;
using System.Globalization;

namespace curso
{
    class Progam
    {
        static void Main(string[] args)
        {
            Console.Write(" Digite a quantidade numeros da matriz, em seguida digite os valores da matrizes:  ");


            int N;
            int[,] A;

            N = int.Parse(Console.ReadLine());
            A = new int[N, N];
            
            for (int i=0; i<N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j=0; j<N; j++)
                {
                    A[i,j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("Diaonal principal: ");
            for(int i=0; i<N; i++)
            {
                Console.Write(A[i, i] + " ");
            }
            Console.WriteLine();

            int cont = 0;
            for (int i=0; i<N; i++)
            {
                for(int j=0; j<N; j++)
                {
                    if (A[i,j] < 0)
                    {
                        cont++;
                    }
                }
            }
            Console.WriteLine("Quantidade de negativos= " + cont);


        }
    }
}