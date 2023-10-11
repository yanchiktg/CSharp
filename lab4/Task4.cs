using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs.lab4
{
    class Task4
    {
        public static void Task()
        {
            Machine[] mas = new Machine[6];
            mas[0] = new Machine();
            mas[1] = new Mobile("zzz", Battery.AcerAspire, 65);
            mas[2] = new Stationary("I", Monitor.LG, Keyboard.REDRAGON);
            mas[3] = new Mobile("Xeon", Battery.AcerExtensa, 75);
            mas[4] = new Tablet("sadsad", Battery.DELLMR90Y, 67, 9.7);
            mas[5] = new Laptop("XX",Battery.ASUSA321025, 93, 10.5);

            for(int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(">>>" + mas[i].GetType().Name);
                Console.WriteLine(mas[i].ToString());
                Console.WriteLine();
            }
        } 
    }
}
