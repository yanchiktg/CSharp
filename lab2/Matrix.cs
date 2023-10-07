using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs.lab2
{
    public class Matrix
    {
        public int[,] matrix;
        public int M, N; 
        public Matrix(int N, int M)
        {
            this.N = N;
            this.M = M;
            matrix = new int[N, M];
            Random rand = new Random();

            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < M; j++)
                {
                    matrix[i, j] = rand.Next(100);
                }
            }
        }

        public void Transp()
        {
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrix[j, i] + " ");
                }
                Console.WriteLine();
            }
        }

        public void Average()
        {
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    sum += matrix[i, j];
                }
            }
            Console.WriteLine(sum / (N * M));
        }

        public void show()
        {
            Console.Write("N = " + N);
            Console.WriteLine(" M = {0}", M);
            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < M; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
