using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs.lab5
{
    public class CashBox : IPrintInfo
    {
        private int Number;
        private string ServiceLanguage;

        public CashBox(int num, string serLg) 
        {
            Number = num;
            ServiceLanguage = serLg;        
        }

        public CashBox() 
        {
            Number = 0;
            ServiceLanguage = "en";        
        }

        public void Input()
        {
            try
            {
                Console.Write("Input cash desk number: ");
                this.Number = Convert.ToInt32(Console.ReadLine());
            } 
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Console.Write("Input service language: ");
                this.ServiceLanguage = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Output()
        {
            Console.WriteLine("Cash desk number: " + Number + "\nService language: " + ServiceLanguage);
        }

    }
}
