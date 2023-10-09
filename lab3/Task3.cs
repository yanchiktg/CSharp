/* Класс «Прямоугольный треугольник». Реализовать ввод и вывод полей данных, 
 * вычисление площади, гипотенузы, а также вывод информации об объекте.
   Class "Right triangle". Implement input and output of data fields, 
   calculation of areas, hypotenuses, as well as output of information about the object.*/

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
