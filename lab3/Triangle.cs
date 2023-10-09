using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs.lab3
{
    class Triangle
    {
        private int a, b;

        public Triangle() { }
        public Triangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public Triangle(int a)
        {
            this.a = a;
            Random random= new Random();
            this.b = random.Next(10);
        }

        public void InOut()
        {
            bool flag = true;
            do
            {
                try
                {
#if DEBUG
                    Console.WriteLine("Введите стороны прямоугольного треугольника a и b: ");
#endif
                    string str = Console.ReadLine();
                    this.a = Convert.ToInt32(str.Split(' ')[0]);
                    this.b = Convert.ToInt32(str.Split(' ')[1]);
                    if (a > 0 && b > 0)
                    {
                        flag = false;
                    }
                    else
                    {
                        Console.WriteLine("Стороны треуголника не могут быть отрицательными!");
#if !DEBUG
                        Random random = new Random();
                        this.a = random.Next(10);
                        this.b = random.Next(10);
                        flag = false;
#endif
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (flag);
            Console.WriteLine("Вы ввели а и b = " + a + " "+ b);
        }

        public void InOut(int a)
        {
            this.a = a;
            Random rand = new Random();
            this.b = rand.Next(10);
        }

        public void Square()
        {
            double s = (a * b) / 2.0;
            Console.WriteLine("Площадь S = " + s);
        }

        public void Square(int a, int b)
        {
            double s = (a * b) / 2.0;
            Console.WriteLine("Площадь S = " + s);
        }

        public void Hypotenuse(int a, int b)
        {
            int c = (int)Math.Sqrt(a*a + b*b);
            Console.WriteLine("Гипотенуза c = " + c);
        }

        public void Hypotenuse()
        {
            int c = (int)Math.Sqrt(a * a + b * b);
            Console.WriteLine("Гипотенуза c = " + c);
        }

        public void Show()
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            
        }
    }
}
