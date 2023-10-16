using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace labs.lab5
{
    public class GoingToWork : IPrintInfo
    {
        //private string Employee;
        private DateTime dateBegin;
        private DateTime dateEnd;
        private CashBox cashBox;
        private Human employee;

        public GoingToWork(DateTime dateBegin, DateTime dateEnd)
        {
            this.dateBegin = dateBegin;
            this.dateEnd = dateEnd;
            this.cashBox = new CashBox();
            this.employee = new Human();
        }

        public GoingToWork()
        {
            dateBegin = DateTime.Now;
            dateEnd = DateTime.Now;
            this.cashBox = new CashBox();
            this.employee = new Human();
        }

        public void setDateBegin(string date)
        {
            int n = 6;
            try
            {
                string[] mas = Regex.Replace(date, @"\D", " ").Trim().Split();

                int[] values = new int[n];
                for (int i = 0, j = 0; i < mas.Length; i++)
                {
                    if (!mas[i].Equals(""))
                    {
                        values[j++] = int.Parse(mas[i]);
                    }
                }

                int a;
                if (values[0] < values[2])
                {
                    a = values[0];
                    values[0] = values[2];
                    values[2] = a;
                }

                DateTime d = new DateTime(values[0], values[1], values[2], values[3], values[4], values[5]);
                this.dateBegin = d;
            }
            catch
            {
                throw new Exception("Invalid date type!");
            }

        }

        public void setDateEnd(string date)
        {
            int n = 6;
            try
            {
                string[] mas = Regex.Replace(date, @"\D", " ").Trim().Split();

                int[] values = new int[n];
                for (int i = 0, j = 0; i < mas.Length; i++)
                {
                    if (!mas[i].Equals(""))
                    {
                        values[j++] = int.Parse(mas[i]);
                    }
                }

                int a;
                if (values[0] < values[2])
                {
                    a = values[0];
                    values[0] = values[2];
                    values[2] = a;
                }

                DateTime d = new DateTime(values[0], values[1], values[2], values[3], values[4], values[5]);
                this.dateEnd = d;
            }
            catch
            {
                throw new Exception("Invalid date type!");
            }

        }

        public void Input()
        {
            try
            {
                Console.Write("Input full name of the employee: ");
                employee.Input();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Console.Write("Input date begin: ");
                setDateBegin(Console.ReadLine());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Console.Write("Input date end: ");
                setDateEnd(Console.ReadLine());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Output()
        {
            employee.Output();
            Console.WriteLine("\nDate/time start: " + dateBegin + "\nDate/time end: " + dateEnd);
        }
    }
}
