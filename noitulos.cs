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
            
            

            Console.WriteLine ("Welcome, Please insert your secret number ");
            Console.Write ("Insert your PIN here: ");
            int pin = int.Parse (Console.ReadLine());
            Console.WriteLine ("Your pin is correct!");

            Console.WriteLine ("Input 1 for withdrawal");
            Console.WriteLine ("Input 2 for Airtime");
            Console.WriteLine ("Input 3 for Deposit");
            Console.WriteLine ("Input 4 for Transfer");

            Console.Write ("Enter your transaction type here: ");
            transaction = Console.ReadLine();

            Switch(transaction)
            {
                Case 1: 
                    Console.WriteLine("How much would you like to Withdraw? ");
                    Console.Write ("Enter amount here: ");
                    int amount = int.Parse(Console.ReadLine());

                    if (amount > money[6])
                    {
                        Console.WriteLine ("You cannot withdraw in excess of N20,000");
                    }
                    else if (amount < money[0])
                    {
                        Console.WriteLine ("You cannot withdraw less than N500");
                    }
                    else if (amount == money[0])
                    {
                        Console.WriteLine ("Please take your N{0}" money[0]);
                        Console.WriteLine ("Thank you for banking with us");
                    }
                    else if (amount == money[1])
                    {
                        Console.WriteLine ("Please take your N{0}" money[1]);
                        Console.WriteLine ("Thank you for banking with us");
                    }
                    else if (amount == money[2])
                    {
                        Console.WriteLine ("Please take your N{0}" money[2]);
                        Console.WriteLine ("Thank you for banking with us");
                    }
                    else if (amount == money[3])
                    {
                        Console.WriteLine ("Please take your N{0}" money[3]);
                        Console.WriteLine ("Thank you for banking with us");
                    }
                    else if (amount == money[4])
                    {
                        Console.WriteLine ("Please take your N{0}" money[4]);
                        Console.WriteLine ("Thank you for banking with us");
                    }
                    else if (amount == money[5])
                    {
                        Console.WriteLine ("Please take your N{0}" money[5]);
                        Console.WriteLine ("Thank you for banking with us");
                    }
                    else if (amount == money[6])
                    {
                        Console.WriteLine ("Please take your N{0}" money[6]);
                        Console.WriteLine ("Thank you for banking with us");
                    }
                    else
                    {
                        Console.WriteLine ("Transaction failed, please take your ATM card and try again");
                    }
                    
                    break;

                Case 2: 
                    Console.WriteLine ("Unable to perform such transaction now");
                    break;

                Case 3:
                    Console.WriteLine ("Unable to perform such transaction now");
                    break;

                Case 4:
                    Console.WriteLine ("Unable to perform such transaction now");
                    break;
                
                default:
                    Console.WriteLine ("Transaction failed");
                    break;
            }   
        }
    }
}
