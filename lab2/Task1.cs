/*Вариант 14
 * Класс «Матрица MxN». Реализовать инициализацию элементов матрицы случайными числами, вывод транспонированной матрицы, 
 * нахождение среднего арифметического всех элементов, а также вывод информации об объекте.  
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs.lab2
{
    class Task1
    {
        public static void Task()
        {
            int N = 0, M = 0;
            bool flag = true;

            do
            {
                try
                {
#if DEBUG
                    Console.WriteLine("Введите размерность матрицы [N M]: ");
#endif
                    string str = Console.ReadLine();
                    N = Convert.ToInt32(str.Split(' ')[0]);
                    M = Convert.ToInt32(str.Split(' ')[1]);
                    flag = false;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (flag);

            Matrix matrix = new Matrix(N, M);
            Console.WriteLine("Инициализированная матрица случайными числами:");
            matrix.show();

            Console.WriteLine("Транспонируемая матрица:");
            matrix.Transp();

            Console.WriteLine("Среднее арифметическое всех элементов:");
            matrix.Average();

        }
    }
}
