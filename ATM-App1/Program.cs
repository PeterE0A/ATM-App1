using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Action action = new Action();
            UI UI = new UI();


            //set up account details
            account.Pin = 1234;
            account.Balance = 750.00;
            account.Name = "Peter";

            // Sets title for console
            Console.Title = "ATM Machine";

            // Sets the text color of the console
            Console.ForegroundColor = ConsoleColor.White;

            UI.Header();
            Console.WriteLine("\n                Note: Actual ATM machine will accept and validate a physical ATM card, \n                read the card number and validate it.");
            Console.WriteLine("\n                Please insert your ATM card");
            Console.SetCursorPosition(6, 25);
            UI.Footer();




            Console.SetCursorPosition(6, 22);
            
            action.PressEnterToContinue();
            action.Loading();
            
            
          


            
            
            Console.ReadKey();
        }
    }
}
