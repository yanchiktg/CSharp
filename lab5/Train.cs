using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace labs.lab5
{
    public class Train : IPrintInfo
    {
        private DateTime dateTime;
        private DateTime dateTimeA;
        private Stations stationFrom;
        private Stations stationTo;
        private TrainType trainType;

        public Train(Stations sF, Stations sT, TrainType tt, DateTime date, DateTime dateA)
        {
            stationFrom = sF;
            stationTo = sT;
            trainType = tt;
            dateTime = date;
            dateTimeA = dateA;
        }
        public Train()
        {
            stationFrom = new Stations();
            stationTo = new Stations();
            trainType = new TrainType();
            dateTime = DateTime.Now;
            dateTimeA = DateTime.Now;
        }

        public void setStationFrom(string s)
        {
            try
            {
                s = s.ToUpper();
                this.stationFrom = (Stations)Enum.Parse(typeof(Stations), s);
            }
            catch (Exception)
            {
                this.stationFrom = Stations.GOMEL;
                throw new Exception("Incorrect station!");
            }
        }

        public void setStationTo(string s)
        {
            try
            {
                s = s.ToUpper();
                this.stationTo = (Stations)Enum.Parse(typeof(Stations), s);
            }
            catch (Exception)
            {
                this.stationTo = Stations.MINSK;
                throw new Exception("Incorrect station!");
            }
        }

        public void setTrainType(string tr)
        {
            try
            {
                tr = tr.ToUpper();
                this.trainType = (TrainType)Enum.Parse(typeof(TrainType), tr);
            }
            catch (Exception)
            {
                this.trainType = TrainType.PASSENGER;
                throw new Exception("Incorrect train typed!");
            }
        }

        public void setDateBegin(string date)
        {
            int n = 2;
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

                DateTime d = new DateTime(2023, 05, 14, values[0], values[1], 0);
                this.dateTime = d;
            }
            catch
            {
                throw new Exception("Invalid date type!");
            }

        }

        public void setDateEnd(string date)
        {
            int n = 2;
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

                DateTime d = new DateTime(2023, 05, 14, values[0], values[1], 0);
                this.dateTimeA = d;
            }
            catch
            {
                throw new Exception("Invalid date type!");
            }

        }

        public void Input()
        {
            Console.WriteLine("Choose station from: ");
            var stations = Enum.GetValues(typeof(Stations));
            foreach(var s in stations)
            {
                Console.WriteLine((int)s + " - " + s);
            }

            try
            {
                string stationf = Console.ReadLine();
                setStationFrom(stationf);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Choose station to: ");
            foreach (var s in stations)
            {
                Console.WriteLine((int)s + " - " + s);
            }

            try
            {
                string stationt = Console.ReadLine();
                setStationTo(stationt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.Write("Input dispatch time: ");
                setDateBegin(Console.ReadLine());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Console.Write("Input arrival time: ");
                setDateEnd(Console.ReadLine());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Choose train type: ");
            var trainType = Enum.GetValues(typeof(TrainType));
            foreach (var tr in trainType)
            {
                Console.WriteLine((int)tr + " - " + tr);
            }

            try
            {
                string type = Console.ReadLine();
                setTrainType(type);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Output()
        {
            Console.WriteLine("\nStation from: " + stationFrom + 
                "\nDate and time of dispatch: " + dateTime.ToShortTimeString() + 
                "\nStation to: " + stationTo + 
                "\nDate and time of arrival: " + dateTimeA.ToShortTimeString() +
                "\nTrain type: " + trainType);
        }
       
    }
}
