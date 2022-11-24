using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ATM_App1
{
    public class Action
    {
        public void PressEnterToContinue()
        {
                Console.WriteLine("\n                Press Enter to Continue...");
        }

        public void Loading(int timer = 10)
        {
            ConsoleKeyInfo inputKey = Console.ReadKey(true);    

            if (inputKey.Key == ConsoleKey.Enter)
            {
                Console.SetCursorPosition(16, 20);
                Console.Write("Please Wait");

                for (int i = 0; i < timer; i++)
                {
                    
                    Console.Write(".");
                    Thread.Sleep(200);
                   
                }
                Console.Clear();

            }

            
        }
        
    }
}
