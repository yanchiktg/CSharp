using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs.lab5
{
    public class Wagon : IPrintInfo
    {
        private int number;
        private WagonType wagonType;
        private Flight flight;

        public Wagon(int num, WagonType wagonT, Flight flt)
        {
            number = num;
            wagonType = wagonT;
            flight = flt;

        }

        public Wagon()
        {
            number = 0;
            wagonType = WagonType.RESERVED_SEAT;
            flight = new Flight();
        }
        
        public void setWagonType(string wt)
        {
            try
            {
                wt = wt.ToUpper();
                this.wagonType = (WagonType)Enum.Parse(typeof(WagonType), wt);
            }
            catch (Exception)
            {
                this.wagonType = WagonType.SITTING;
                throw new Exception("Incorrect wagon type!");
            }
        }
        public void Input()
        {
            flight.Input();
            try
            {
                Console.Write("Input number of wagon: ");
                this.number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Choose wagon type: ");
            var wType = Enum.GetValues(typeof(WagonType));
            foreach (var w in wType)
            {
                Console.WriteLine((int)w + " - " + w);
            }

            try
            {
                string wt = Console.ReadLine();
                setWagonType(wt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void Output()
        {
            flight.Output();
            Console.WriteLine("Number of wagon: " + number + "\nWagon type: " + wagonType);
        }
    }
}
