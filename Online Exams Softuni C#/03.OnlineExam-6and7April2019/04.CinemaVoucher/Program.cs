using System;

namespace _04.CinemaVoucher
{
    class Program
    {
        static void Main(string[] args)
        {
            int voucherValue = int.Parse(Console.ReadLine());

            string purchase = Console.ReadLine();
            int price = 0;
            int ticketsCount = 0;
            int otherPurchases = 0;

            while (purchase != "End")
            {
                int purchaseLength = purchase.Length;
                if (purchase.Length > 8)
                {
                    price = purchase[0];
                    price += purchase[1];
                    if (voucherValue < price)
                    {
                        break;
                    }
                    ticketsCount++;
                }
                else
                {
                    price = purchase[0];
                    if (voucherValue < price)
                    {
                        break;
                    }
                    otherPurchases++;
                }
                voucherValue -= price;

                purchase = Console.ReadLine();
            }
            Console.WriteLine(ticketsCount);
            Console.WriteLine(otherPurchases);
        }
    }
}
