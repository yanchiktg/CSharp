using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace labs.lab4
{
    public enum Battery
    {
        AcerAspire,
        AcerExtensa,
        AppleA1417,
        ASUSA321025,
        DELLMR90Y,
        Default
    }
    public enum Keyboard
    {
        Logitech,
        REDRAGON,
        Gembird,
        Default
    }
    public enum Monitor
    {
        LG,
        Philips,
        Acer,
        AOC,
        Default
    }

    //ЭВМ
    class Machine
    {
        private string cpu;
        public string CPU
        {
            get { return cpu; }
            set 
            {
                if(value != string.Empty)
                {
                    cpu = value;
                }
                else
                {
                    cpu = "default";
                }
            }
        }

        public Machine()
        {
            cpu = "Xeon";
        }
        public Machine(string cpu)
        {
            this.cpu = cpu;
        }

        public override string ToString()
        {
            return "CPU: " + cpu;
        }

    }

    //Стационарный
    class Stationary : Machine
    {
        public Monitor Monitor { get; set; }
        public Keyboard Keyboard { get; set; }
        public Stationary(string cpu, Monitor m, Keyboard k)
            : base(cpu)
        {
            this.Monitor = m;
            this.Keyboard = k;
        }

        public override string ToString()
        {
            return base.ToString() + "\nMonitor: " + Monitor + "\nKeyboard: " + Keyboard;
        }
    }
    
    //Мобильный

    class Mobile : Machine
    {
        //public Battery battery;

        public Battery Battery { get; set; }

        public int power;

        public Mobile(string cpu, Battery battery, int power)
            :base(cpu)
        {
            Battery = battery;
            this.power = power;
        }
        public Mobile()
            :base()
        {
            Battery = Battery.Default;
            power = 100;
        }

        public override string ToString()
        {
            return base.ToString() + "\nBattery: " + Battery + "\nPower: " + power;
        }
    }


    class Tablet : Mobile
    {
        public double Diagonal { get; set; }

        public Tablet()
            :base()
        {
            Diagonal = 0;
        }

        public Tablet(string cpu, Battery battery, int power, double diagonal)
            :base(cpu, battery, power)
        {
            Diagonal = diagonal;
        }

        public override string ToString()
        {
            return base.ToString() + "\nDiagonal: " + Diagonal;
        }
    }

    class Laptop : Mobile
    {
        public double ScreenFrequency { get; set; }

        public Laptop()
            : base()
        {
            ScreenFrequency = 60;
        }

        public Laptop(string cpu, Battery battery, int power, double sf)
            : base(cpu, battery, power)
        {
            ScreenFrequency = sf;
        }

        public override string ToString()
        {
            return base.ToString() + "\nScreen frequency: " + ScreenFrequency;
        }
    }
}
