using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ATM_App1
{
    public class BankAccount
    {
       

        public string Pin { get; set; }
        public string Amount { get; set; }
        public double Balance { get; set; }
        public string Name { get; set; }

        public bool CheckIfPinIsCorrect(string pin)
        {
            if (pin == Pin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void PressEnterToContinue()
        {
            Console.WriteLine("\n                Press Enter to Continue...");
        }

        public void Loading(int timer = 10)
        {
            ConsoleKeyInfo inputKey = Console.ReadKey(true);

            if (inputKey.Key == ConsoleKey.Enter)
            {
                Console.SetCursorPosition(16, 23);
                Console.Write("Please Wait");

                for (int i = 0; i < timer; i++)
                {

                    Console.Write(".");
                    Thread.Sleep(200);

                }
                Console.Clear();

            }
        }


        public static string HidePin()
        {
            StringBuilder sb = new StringBuilder();
            ConsoleKeyInfo keyInfo;

            do
            {

                keyInfo = Console.ReadKey(true);

                if (!char.IsControl(keyInfo.KeyChar))
                {
                    sb.Append(keyInfo.KeyChar);
                    Console.Write("*");
                }

            } while (keyInfo.Key != ConsoleKey.Enter);

            return sb.ToString();
        }


        public double CheckBalance()
        {
            return Balance;
        }

        public bool Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance = Balance - amount;
                return true;
            }
            else
            {
                return false;
            }

        }

        public double Deposit(double amount)
        {
            Balance += amount;
            return Balance;
        }

    }
}
