using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Программа рассчитывает сумму первой матрицы и матрицы транспонированной относительно второй. 
Обе матрицы хранятся в отдельных файлах. 
*/
namespace LibraryLab_6
{
    public class Matrix
    {
        private double[,] matrix;
        int n, m;

        public Matrix()
        {
            n = 3; m = 3;
            matrix = new double[3, 3];
        }

        public void GenerateM(int N, int M)
        {
            n = N; m = M;
            matrix = new double[N, M];

            Random rand = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    matrix[i, j] = Math.Round((rand.NextDouble() * 100 - 0), 2);
        }

        public void InMatrix(string pFileName)
        {
            if (matrix.Length > 0)
            {
                if (File.Exists(pFileName))
                    File.Delete(pFileName);
                
                FileInfo fi = new FileInfo(pFileName);
                TextWriter tw = fi.CreateText();

                tw.WriteLine(n.ToString());
                tw.WriteLine(m.ToString());

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        tw.WriteLine(i.ToString() + " " + j.ToString() + " " + matrix[i, j].ToString());
                tw.Close();
            }
        }

        public void PrintM()
        {
            if (matrix.Length > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                        Console.Write("{0, -8}", matrix[i, j].ToString());
                    Console.WriteLine();
                }
            }
        }

        public Boolean LoadM(string pFileName)
        {
            if (File.Exists(pFileName))
            {
                try
                {
                    TextReader tr = File.OpenText(pFileName);
                    n = Convert.ToInt32(tr.ReadLine());
                    m = Convert.ToInt32(tr.ReadLine());

                    matrix = new double[n, m];
                    string s;
                    string[] substring;

                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < m; j++)
                        {
                            s = tr.ReadLine();
                            substring = s.Split(new char[] {' '}, 3);
                            matrix[i, j] = Convert.ToDouble(substring[2]);
                        }
                    tr.Close();
                    return true;

                }catch
                {
                    return false;
                }
            }
            return false;
        }

        public void MatrixSum(Matrix a, Matrix b)
        {
            try
            {
                for (int i = 0; i < a.n; i++)
                {
                    for (int j = 0; j < a.m; j++)
                    {
                        Console.Write((a.matrix[i, j] + b.matrix[j, i]) + "   ");
                    }
                    Console.WriteLine();
                }
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
