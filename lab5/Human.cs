using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs.lab5
{
    public class Human : IPrintInfo
    {
        private string FIO;

        public Human(string f)
        {
            FIO = f;
        }

        public Human()
        {
            FIO = string.Empty;
        }

        public void Input()
        {
            try
            {
                this.FIO = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Output()
        {
            Console.WriteLine("Full name: " + FIO);
        }
    }
}
