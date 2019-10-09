using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakfast_Club
{
    public class MenuItem
    {
        public string OrderName;
        public double OrderPrice;
    }
    class Payment
    {
        List<Menu> menus = Menu.MenuItems();
        List<MenuItem> cart = new List<MenuItem>();

        public void CreditCardPaymentNumber(/*string crnumber,string date,string cvv*/)
        {
            bool con = true;
            while (con)
            {
                Console.WriteLine("Please enter your credit card number: ");
                decimal crnumber = decimal.Parse(Console.ReadLine());
                string crnumberstring = crnumber.ToString();
                if (crnumberstring.Length != 16)
                {
                    Console.WriteLine("You did not enter a valid credit card number. Please try again");
                    con = true;
                }
                else
                {
                    Console.WriteLine("Thank you!");
                    con = false;
                }
            }
        }
        public void GetCreditCardDate()
        {
            bool con = true;
            while (con)
            {
                Console.WriteLine("Please enter the expiration date (enter two digits for month and four for year): ");
                int date = int.Parse(Console.ReadLine());
                string datestring = date.ToString();
                string substring1 = datestring.Substring(0, 2);
                int datesubstring1 = Int32.Parse(substring1);
                string substring2 = datestring.Substring(2);
                int datesubstring2 = Int32.Parse(substring2);

                if (datestring.Length != 6 || datesubstring1 > 12 || datesubstring2 > 3000 || datesubstring2 < 1900 || datesubstring1 < 0)
                {
                    Console.WriteLine("You did not enter a valid date.Please try again");
                    con = true;
                }
                else
                {
                    Console.WriteLine("Thank you!");
                    con = false;
                }
            }
        }
        public void Getcreditcardcvv()
        {
            bool con = true;
            while (con)
            {
                Console.WriteLine("Please enter the number on the back of your card(cvv): ");
                int cvv = int.Parse(Console.ReadLine());
                string cvvstring = cvv.ToString();
                if (cvvstring.Length != 3)
                {
                    Console.WriteLine("You did not enter a cvv number.Please try again");
                    con = true;
                }
                else
                {
                    Console.WriteLine("We have received your payment.Thank you for your business");
                    con = false;
                }
            }
        }
        public void Check(double grandTotal)

        {


            Console.WriteLine("Please enter your check card number: ");
            decimal cknumber = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Thank you a payment for {0} has been procesed", grandTotal);

        }
        public void Cash(double grandTotal)
        {

            Console.WriteLine("How much cash do you want to insert: ");
            string a = Console.ReadLine();
            double amount = double.Parse(a);
            //  double amount = double.Parse(Console.ReadLine());7


            if (grandTotal < amount)
            {
                double change = amount - grandTotal;
                Console.WriteLine("Here is your change: " + change.ToString("C2", CultureInfo.CurrentCulture));
            }
            else if (grandTotal == amount)
            {
                Console.WriteLine(" Payment Accepted.  Thank you");
            }

            else
            {
                Console.WriteLine("That's not enough money. you need {0}.  try Again", amount - grandTotal);
                Console.WriteLine("How much cash do you want to insert: ");
                a = Console.ReadLine();
                amount = double.Parse(a);
                //   amount = double.Parse(Console.ReadLine());

            }
        }
    }
}

