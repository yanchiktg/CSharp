using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace labs.lab5
{
    public class Ticket : IPrintInfo
    {
        private int Price;
        private int PlaceNumber;
        private Human Passenger;
        private DateTime dateTime;
        private Wagon wagon;
        private CashBox cashBox;

        public Ticket(int Price, int PlaceNumber, Human human, DateTime dateTime, Wagon wagon, CashBox cashBox)
        {
            this.Price = Price;
            this.PlaceNumber = PlaceNumber;
            Passenger = human;
            this.dateTime = dateTime;
            this.wagon = wagon;
            this.cashBox = cashBox;
        }
        public Ticket()
        {
            Price = 0;
            PlaceNumber = 0;
            Passenger = new Human();
            dateTime = DateTime.Now;
            wagon = new Wagon();
            cashBox = new CashBox();
        }

        public void setDate(string date)
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
                this.dateTime = d;
            }
            catch
            {
                throw new Exception("Invalid date type!");
            }

        }
        public void Input()
        {
            wagon.Input();
            cashBox.Input();
            try
            {
                Console.Write("Input price: ");
                this.Price = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Console.Write("Input date sale: ");
                setDate(Console.ReadLine());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Console.Write("Input place number: ");
                this.PlaceNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Console.Write("Input full name of the passenger: ");
                Passenger.Input();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Output()
        {
            wagon.Output();
            Console.WriteLine("\nPrice: " + Price +
               "\nPlace number: " + PlaceNumber +
               "\nDate of sale: " + dateTime.ToLongDateString());
            Passenger.Output();
        }
    }
}
