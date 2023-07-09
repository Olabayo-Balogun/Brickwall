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
            Console.WriteLine ("Please Select your transaction type number");

            Console.Write("1 =========================  withdrawal");
            Console.Write("2 =========================  transfer");
            Console.Write("3 =========================  airtime");
            Console.Write("4 =========================  pay bills");

            int TransactReply = int.Parse(Console.ReadLine());

            if (TransactReply = 1)
            {
                Console.WriteLine("How much would you like to withdraw? ");
                Console.Write ("Enter amount here: ");
                int amount = int.Parse (Console.ReadLine ());

                if (amount>money[6])
                {
                    Console.WriteLine ("You cannot withdraw in excess of twenty thousand naira ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Press any key to exit!");
                    Console.ReadLine();
                }
                else if (amount<money[0])
                {
                    Console.WriteLine ("You cannot withdraw less than five hundred naira");
                    Console.WriteLine(" ");
                    Console.WriteLine("Press any key to exit!");
                    Console.ReadLine();
                }
                else if (amount == money[0])
                {
                    Console.WriteLine ("Please take your " (money[0]));
                    Console.WriteLine ("Thank you for banking with us");
                    Console.WriteLine(" ");
                    Console.WriteLine("Press any key to exit!");
                    Console.ReadLine();
                }
                else if (amount == money[1])
                {
                    Console.WriteLine ("Please take your " (money[1]));
                    Console.WriteLine ("Thank you for banking with us");
                    Console.WriteLine(" ");
                    Console.WriteLine("Press any key to exit!");
                    Console.ReadLine();
                }
                else if (amount == money[2])
                {
                    Console.WriteLine ("Please take your " (money[2]));
                    Console.WriteLine ("Thank you for banking with us");
                    Console.WriteLine(" ");
                    Console.WriteLine("Press any key to exit!");
                    Console.ReadLine();
                }
               else if (amount == money[3])
                {
                    Console.WriteLine ("Please take your " (money[3]));
                    Console.WriteLine ("Thank you for banking with us");
                    Console.WriteLine(" ");
                    Console.WriteLine("Press any key to exit!");
                    Console.ReadLine();
                }
                else if (amount == money[4])
                {
                    Console.WriteLine ("Please take your " (money[4]));
                    Console.WriteLine ("Thank you for banking with us");
                    Console.WriteLine(" ");
                    Console.WriteLine("Press any key to exit!");
                    Console.ReadLine();
                }
                else if (amount == money[5])
                {
                    Console.WriteLine ("Please take your " (money[5]));
                    Console.WriteLine ("Thank you for banking with us");
                    Console.WriteLine(" ");
                    Console.WriteLine("Press any key to exit!");
                    Console.ReadLine();
                }
                else if (amount == money[6])
                {
                    Console.WriteLine ("Please take your " (money[6]));
                    Console.WriteLine ("Thank you for banking with us");
                    Console.WriteLine(" ");
                    Console.WriteLine("Press any key to exit!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine ("Transaction failed, please take your atm card and try again");
                    Console.WriteLine(" ");
                    Console.WriteLine("Press any key to exit!");
                    Console.ReadLine();
                }
            }
            else  if (TransactReply = 2)
            {
                Console.WriteLine ("Unable to perform such transaction now");
                Console.WriteLine(" ");
                Console.WriteLine("Press any key to exit!");
                Console.ReadLine();
            }
            else if (TransactReply = 3)
            {
                Console.WriteLine ("Unable to perform such transaction now");
                Console.WriteLine(" ");
                Console.WriteLine("Press any key to exit!");
                Console.ReadLine();
            }
            else if (TransactReply = 4)
            {
                Console.WriteLine ("Unable to perform such transaction now");
                Console.WriteLine(" ");
                Console.WriteLine("Press any key to exit!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine ("Transaction failed");
                Console.WriteLine(" ");
                Console.WriteLine("Press any key to exit!");
                Console.ReadLine();
            }
            
        }
    }
}
