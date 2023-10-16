using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs.lab5
{
    public class Task5
    {
        public static void Task() 
        {
            bool flag = true;
            IPrintInfo[] mas = new IPrintInfo[6];
            mas[0] = new Train();
            mas[1] = new Flight();
            mas[2] = new Wagon();
            mas[3] = new Ticket();
            mas[4] = new CashBox();
            mas[5] = new GoingToWork();

            while (flag)
            {
                Console.Clear();
                int n;
                Console.WriteLine("Select an element to interact:");
                Console.WriteLine("1 - Train \n2 - Flight \n3 - Wagon \n4 - Ticket \n5 - CashBox \n6 - GoingToWork \n0 - Exit");
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    if((n < 1 || n > 6) && n != 0) 
                    {
                        throw new Exception("Choose the provided option!");                    
                    }
                    if(n == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                int m;
                Console.Clear();
                Console.WriteLine("1 - Input \n2 - Output \n3 - Back");
                try
                {
                    m = Convert.ToInt32(Console.ReadLine());
                    if (m < 1 || m > 3)
                    {
                        throw new Exception("Choose the provided option!");
                    }
                    if (m == 1)
                    {
                        mas[n - 1].Input();
                    }
                    if (m == 2)
                    {
                        mas[n - 1].Output();
                        Console.ReadKey();
                    }
                    else
                    {
                        continue;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Choose the provided option!");
                    continue;
                }

                
            }

            /*Console.WriteLine("-------------------------");
            IPrintInfo a = new Ticket();
            a.Input();
            Console.WriteLine("-------------------------");
            a.Output();

            /*Console.WriteLine("-------------------------");
            IPrintInfo b = new GoingToWork();
            b.Input();
            Console.WriteLine("-------------------------");
            b.Output();*/
        }
    }
}
