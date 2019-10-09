using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakfast_Club
{
    class Order
    {
        public string OrderName { get; set; }
        public double OrderPrice { get; set; }


        List<Menu> menus = Menu.MenuItems();
        public List<Order> cart = new List<Order>();
        public void PrintMenu()
        {

            int i = -1;
            Console.WriteLine("".ToString().PadRight(4) + " DISH ".PadRight(25, '_') + " CATEGORY".PadLeft(10, '_') + " PRICE".PadLeft(15, '_'));
            Console.WriteLine("");

            foreach (var n in menus)
            {
                i++;
                Console.WriteLine((i + "-").ToString().PadRight(4) + n.Name.PadRight(25, '_') + n.Category.PadLeft(10, '_') + n.Price.ToString("C", CultureInfo.CurrentCulture).PadLeft(15, '_'));
            }
            Console.WriteLine(menus.Count + 1 + ". End Order and Procede to payment");
        }
        public List<Order> AddMenuItem(int input, int howMany)
        {
            for (int i = 0; i < howMany; i++)
            {
                cart.Add(new Order { OrderName = menus[input].Name, OrderPrice = menus[input].Price });
            }
            return cart;
        }

        public double GetGrandTotal()
        {
            double SubTotal = cart.Sum(x => x.OrderPrice);
            double SalesTax = SubTotal * 0.07;

            double grandTotal = SubTotal + SalesTax;

            return grandTotal;

        }
        public void PrintCart()
        {
            double SubTotal = cart.Sum(cart => cart.OrderPrice);
            double SalesTax = SubTotal * 0.07;
            double grandTotal = SubTotal + SalesTax;

            int i = 0;

            Console.WriteLine("Cart:");
            foreach (Order item in cart)
            {
                i++;
                Console.WriteLine((i + "-").ToString().PadRight(4) + item.OrderName.PadRight(25, ' ') + item.OrderPrice.ToString("C", CultureInfo.CurrentCulture).PadLeft(15, ' '));

                //  Console.WriteLine(i + "." + item.OrderName.PadLeft(25,' ')  + item.OrderPrice.ToString("C", CultureInfo.CurrentCulture).PadLeft(15, '_'));
            }
            Console.WriteLine("________________________________");
            Console.WriteLine("\n Sub Total: " + SubTotal.ToString("C2", CultureInfo.CurrentCulture));
            Console.WriteLine("\n Tax: " + SalesTax.ToString("C2", CultureInfo.CurrentCulture));
            Console.WriteLine("\n Grand Total: " + grandTotal.ToString("C2", CultureInfo.CurrentCulture));
            Console.WriteLine("________________________________");
        }

    }
}

