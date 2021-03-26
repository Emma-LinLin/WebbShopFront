using System;
using System.Collections.Generic;
using System.Text;

namespace WebbShopFrontInlamning.Views
{
    class AdminView
    {
        public static void StartPage()
        {
            Console.WriteLine("You have to be logged in to proceed.");
        }

        public static void AdminPage()
        {
            Console.WriteLine("Admin page");
            Console.WriteLine();
            Console.WriteLine("1. Manage books");
            Console.WriteLine("2. Manage categories");
            Console.WriteLine("3. Manage accounts");
            Console.WriteLine("4. Manage sold items");
            Console.WriteLine("5. Return to main meny");
        }

        public static void VerifyAdminFailed()
        {
            Console.WriteLine("You're not authorized.");
        }
    }
}
