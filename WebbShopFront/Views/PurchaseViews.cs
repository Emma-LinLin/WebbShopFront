using System;
using System.Collections.Generic;
using System.Text;

namespace WebbShopFrontInlamning.Views
{
    /// <summary>
    /// Displays view for Purchase
    /// </summary>
    class PurchaseViews
    {
        /// <summary>
        /// Displays start page of purchase
        /// </summary>
        public static void StartPage()
        {
            Console.WriteLine("What are you in the mood for?");
            Console.WriteLine("These books are available right now!");
            Console.WriteLine();
        }

        /// <summary>
        /// Displays an option to view or purchase
        /// </summary>
        public static void DisplayPurchaseMeny()
        {
            Console.WriteLine();
            Console.WriteLine("1. View details");
            Console.WriteLine("2. Purchase");
        }
    }
}
