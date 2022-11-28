using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
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
            start:

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
                
                   start2:
               
                if (isPinCorrect)
                {
                    UI.Header();
                    Console.WriteLine($"\n                Hello, {account.Name}! \n\n                Please Choose what would like to do next:");
                    Console.WriteLine($"\n\n                1. Check your Balance\n" + "\n                2. Withdraw" + "\n\n                3. Deposit");
                    Console.SetCursorPosition(6, 28);
                    UI.Footer();
                    Console.SetCursorPosition(6, 25);

                    account.PressEnterToContinue();
                    

                    Console.SetCursorPosition(58, 9);
                    account.Loading();
                    int option = Convert.ToInt32(Console.ReadLine());
               


                switch (option)
                {
                    case 1:
                        UI.Header();
                        double balance = account.CheckBalance();
                        Console.WriteLine($"\n                Balance: {balance}");
                        Console.SetCursorPosition(6, 28);
                        UI.Footer();
                        Console.SetCursorPosition(6, 25);

                        account.PressEnterToContinue();
                        account.Loading();
                        goto start2;
                        break;

                    case 2:

                    start3:

                        UI.Header();
                       
                        double balance1 = account.CheckBalance();
                        Console.WriteLine($"\n                Balance: {balance1}");
                        Console.WriteLine($"\n\n                Please provide the amount you want to Withdraw: ");
                        Console.SetCursorPosition(6, 28);
                        UI.Footer();
                        Console.SetCursorPosition(6, 25);


                        
                        account.PressEnterToContinue();
                        account.Loading();


                        Console.SetCursorPosition(64, 10);
                        double amount = double.Parse(Console.ReadLine());
                        bool withdraw = account.Withdraw(amount);

                        
                        if (withdraw)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\n\n                Transaction successfull! Your new Balance is: {account.Balance}");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"\n\n                Insufficient Funds! Please Try Again.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadLine();
                            goto start3;
                        }
                        

                        Console.SetCursorPosition(6, 28);
                        UI.Footer();
                        Console.SetCursorPosition(6, 25);

                        account.PressEnterToContinue();
                        account.Loading();
                        goto start2;

                        break;

                    case 3:

                        start4:
                        UI.Header();

                        double balance2 = account.CheckBalance();
                        Console.WriteLine($"\n                Balance: {balance2}");
                        Console.WriteLine($"\n\n                Please provide the amount you want to Deposit: ");
                        Console.SetCursorPosition(6, 28);
                        UI.Footer();
                        Console.SetCursorPosition(6, 25);



                        account.PressEnterToContinue();
                        account.Loading();


                        Console.SetCursorPosition(64, 10);
                        double amount1 = double.Parse(Console.ReadLine());
                        double deposit = account.Deposit(amount1);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\n\n                Transaction successfull! Your new Balance is: {account.Balance}");
                        Console.ForegroundColor = ConsoleColor.White;

                      
                        Console.SetCursorPosition(6, 28);
                        UI.Footer();
                        Console.SetCursorPosition(6, 25);
                  
                        account.PressEnterToContinue();    
                        account.Loading();

                        goto start2;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(16, 20);
                        Console.WriteLine($"\n\n                Option is not Valid! Please try again");
                        Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        goto start2;
                        break;
                }



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

                goto start;

                    
                }

            Console.ReadKey();
        }
    }
}
