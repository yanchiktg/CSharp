using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace labs.lab5
{
    public class Flight : IPrintInfo
    {
        private DateTime Date;
        private Train train;

        public Flight(DateTime date, Train train)
        {
            Date = date;
            this.train = train;
        }

        public Flight()
        {
            Date = DateTime.Now;
            train = new Train();
        }

        public void setDateTime(string date)
        {
            int n = 3;
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

                DateTime d = new DateTime(values[0], values[1], values[2]);
                this.Date = d;
            }
            catch
            {
                throw new Exception("Invalid date type!");
            }

        }

        public void Input()
        {
            train.Input();
            try
            {
                Console.Write("Input flight date: ");
                setDateTime(Console.ReadLine());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Output()
        {
            train.Output();
            Console.WriteLine("\nDate: " + Date.ToLongDateString());
        }
    }
}
