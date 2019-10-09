using System;
using System.Collections.Generic;

namespace Breakfast_Club
{
    public class BreakFastClubApp
    {
        List<Menu> menus = Menu.MenuItems();
        Order order = new Order();
        int input = 0;
        string inp = "";
        int howMany = 0;

        public void RunApp()
        {
            Console.WriteLine("Welcome to the Breakfast Club ");


            bool orderMore = true;
            while (orderMore)
            {
                Console.WriteLine("\n Select a Number from the Menu ");
                order.PrintMenu();
                inp = Console.ReadLine();
                input = int.Parse(inp);

                if (input >= 0 && input <= menus.Count)
                {
                    Console.WriteLine(menus[input].Name + "  \n DESCRIPTION: " + menus[input].Description);
                    Console.WriteLine("do you want to buy this item? Y/N ");
                    string b = Console.ReadLine().ToLower().Trim();

                    while (b != "n" && b != "y")
                    {
                        Console.WriteLine("invalid entry.  please enter Y or N");
                        b = Console.ReadLine().ToLower().Trim();
                    }
                    if (b == "y")
                    {
                        if (input > 0 && input < menus.Count)
                        {
                            Console.WriteLine("How Many ?");
                            string h = Console.ReadLine();
                            try
                            {
                                howMany = int.Parse(h);
                            }
                            catch
                            {
                                Console.WriteLine("You have not enter a number. please enter number ");
                                h = Console.ReadLine();
                                howMany = int.Parse(h);
                            }
                            order.AddMenuItem(input, howMany);
                            order.PrintCart();
                            double a = order.GetGrandTotal();
                            Console.WriteLine("your total is:" + a);
                        }
                    }
                }
                else
                {
                    order.PrintCart();

                    Checkout();
                    break;
                }
            }




        }
        public void Checkout()
        {
            double grandTotal = order.GetGrandTotal();

            Console.WriteLine("Ok, How would you like to pay?");
            Console.WriteLine("1: Credit/Debit Card");
            Console.WriteLine("2: Check");
            Console.WriteLine("3: Cash");

            string pay = Console.ReadLine().ToLower().Trim();

            Payment check = new Payment();
            Payment card = new Payment();
            Payment cash = new Payment();

            if (pay == "credit/debit" || pay == "1" || pay == "credit" || pay == "debit")
            {
                Console.WriteLine("Cradit/Debit Card Payment:");
                card.CreditCardPaymentNumber();
                card.GetCreditCardDate();
                card.Getcreditcardcvv();
            }
            else if (pay == "Check" || pay == "2")
            {
                Console.WriteLine("Check Payment:");
                check.Check(grandTotal);
            }
            else if (pay == "Cash" || pay == "3")
            {
                Console.WriteLine("Cash Payment:");
                cash.Cash(grandTotal);
            }
            else
            {
                Console.WriteLine("Please leave your information and fill-up pay later form!");
                Console.WriteLine("Invalid entry please select 1-Card, 2- Check or 3- Cash ");
                pay = Console.ReadLine();
            }
            Console.WriteLine("Good Bye, Come back soon");

        }

    }


}
