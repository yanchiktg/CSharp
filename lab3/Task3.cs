/* Класс «Прямоугольный треугольник». Реализовать ввод и вывод полей данных, 
 * вычисление площади, гипотенузы, а также вывод информации об объекте. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace labs.lab3
{
    class Task3
    {
        public static void Task()
        {
            /*int a = 0, b = 0, c = 0;
            bool flag = true;
            do
            {
                try
                {
#if DEBUG
                    Console.WriteLine("Введите стороны прямоугольного треугольника a и b: ");
#endif
                    string str = Console.ReadLine();
                    a = Convert.ToInt32(str.Split(' ')[0]);
                    b = Convert.ToInt32(str.Split(' ')[1]);
                    //c = Convert.ToInt32(str.Split(' ')[2]);
                    flag = false;
                }
                catch(Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            } while (flag);*/

            Triangle triangle = new Triangle();
            //triangle.Show();
            triangle.InOut();
            triangle.Show();
            triangle.Square();
            //triangle.Hypotenuse(a, b);
            triangle.Hypotenuse();
            
        }
    }
}
