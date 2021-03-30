using System;
using System.Collections.Generic;
using System.Text;

namespace WebbShopFrontInlamning.Views
{
    class PurchaseViews
    {
        public static void StartPage()
        {
            Console.WriteLine("What are you in the mood for?");
            Console.WriteLine("These books are available right now!");
            Console.WriteLine();
        }

        public static void DisplayPurchaseMeny()
        {
            Console.WriteLine();
            Console.WriteLine("1. View details");
            Console.WriteLine("2. Purchase");
        }
    }
}
