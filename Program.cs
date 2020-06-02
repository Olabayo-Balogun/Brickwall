using System;
using System.Collections.Generic;
using System.Linq;

namespace csassignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] money = new int[7];

            money[0] = 500;
            money[1] = 1000;
            money[2] = 2000;
            money[3] = 5000;
            money[4] = 10000;
            money[5] = 15000;
            money[6] = 20000;
            
            List<string> transaction = new List<string>();
            transaction.Add("withdrawal");
            transaction.Add("transfer");
            transaction.Add("airtime");
            transaction.Add("pay bills");

            Console.WriteLine ("Welcome, please insert your secret number ");
            Console.Write ("Insert your PIN here: ");
            int pin = int.Parse (Console.ReadLine());
            Console.WriteLine ("Your pin is correct");
            Console.WriteLine ("Please enter your transaction type ");
            Console.Write ("Enter your transaction type here: ");
            transaction = Console.ReadLine();

            if (transaction = (transaction[0]))
            {
                Console.WriteLine("How much would you like to withdraw? ");
                Console.Write ("Enter amount here: ");
                int amount = int.Parse (Console.ReadLine ());

                if (amount>money[6])
                {
                    Console.WriteLine ("You cannot withdraw in excess of twenty thousand naira ");
                }
                else if (amount<money[0])
                {
                    Console.WriteLine ("You cannot withdraw less than five hundred naira");
                }
                else if (amount == money[0])
                {
                    Console.WriteLine ("Please take your " (money[0]));
                    Console.WriteLine ("Thank you for banking with us");
                }
                else if (amount == money[1])
                {
                    Console.WriteLine ("Please take your " (money[1]));
                    Console.WriteLine ("Thank you for banking with us");
                }
                else if (amount == money[2])
                {
                    Console.WriteLine ("Please take your " (money[2]));
                    Console.WriteLine ("Thank you for banking with us");
                }
               else if (amount == money[3])
                {
                    Console.WriteLine ("Please take your " (money[3]));
                    Console.WriteLine ("Thank you for banking with us");
                }
                else if (amount == money[4])
                {
                    Console.WriteLine ("Please take your " (money[4]));
                    Console.WriteLine ("Thank you for banking with us");
                }
                else if (amount == money[5])
                {
                    Console.WriteLine ("Please take your " (money[5]));
                    Console.WriteLine ("Thank you for banking with us");
                }
                else if (amount == money[6])
                {
                    Console.WriteLine ("Please take your " (money[6]));
                    Console.WriteLine ("Thank you for banking with us");
                }
                else
                {
                    Console.WriteLine ("Transaction failed, please take your atm card and try again");
                }
            }
            else  if (transaction = transaction[1])
            {
                Console.WriteLine ("Unable to perform such transaction now");
            }
            else if (transaction = transaction[2])
            {
                Console.WriteLine ("Unable to perform such transaction now");
            }
            else if (transaction = transaction[3])
            {
                Console.WriteLine ("Unable to perform such transaction now");
            }
            else
            {
                Console.WriteLine ("Transaction failed");
            }
            
        }
    }
}
