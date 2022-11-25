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
           
            UI UI = new UI();


            //set up account details
            account.Pin = "1234"/*1234*/;
            account.Balance = 750.00;
            account.Name = "Peter";

            // Sets title for console
            Console.Title = "ATM Machine";

            // Sets the text color of the console
            Console.ForegroundColor = ConsoleColor.White;

            // First Page

            UI.Header();
            Console.WriteLine("\n                Note: Actual ATM machine will accept and validate a physical ATM card, \n                read the card number and validate it.");
            Console.WriteLine("\n                Please insert your ATM card");
            Console.SetCursorPosition(6, 28);
            UI.Footer();

            Console.SetCursorPosition(6, 25);
           
            account.PressEnterToContinue();
            
            account.Loading();

            //second page

            UI.Header();
            Console.WriteLine("\n                Please Enter Your PIN:");
            Console.SetCursorPosition(6, 28);
            UI.Footer();
   
            Console.SetCursorPosition(6, 25);
           
            account.PressEnterToContinue();
            

            Console.SetCursorPosition(39, 7);
            string pin = BankAccount.HidePin();
            account.Loading();

            bool isPinCorrect = account.CheckIfPinIsCorrect(pin);

           
            //FINISH LATER


                if (isPinCorrect)
                {
                    UI.Header();
                    Console.WriteLine($"\n                Hello, {account.Name}! \n\n                Please Choose what would like to do next:");
                    Console.SetCursorPosition(6, 28);
                    UI.Footer();
                    Console.SetCursorPosition(6, 25);

                    account.PressEnterToContinue();

                }
                else
                {

                    UI.Header();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n                PIN is not correct. Please try again");

                    Console.SetCursorPosition(6, 28);
                    Console.ForegroundColor = ConsoleColor.White;
                    UI.Footer();
                    Console.SetCursorPosition(6, 25);

                    account.PressEnterToContinue();
                    account.Loading();


                }



            

           
            
           
         










            Console.ReadKey();
        }
    }
}
