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
            Console.WriteLine("These books are available right now: ");
            Console.WriteLine();
        }

        public static void SelectItem()
        {
            Console.WriteLine();
            Console.WriteLine("You can select one of the following books either view more details or purchase.");
            Console.WriteLine("Select [0] to return to main meny.");
            Console.WriteLine();
        }
    }
}
