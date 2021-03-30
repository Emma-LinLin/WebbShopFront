using System;
using System.Collections.Generic;
using System.Text;

namespace WebbShopFrontInlamning.Views
{
    class AccountViews
    {
        public static void LoginPage()
        {
            Console.WriteLine("Login page");
            Console.WriteLine();
            Console.WriteLine("Please fill in the following: ");
            Console.WriteLine("1. User name: ");
            Console.WriteLine("2. Password: ");
        }
        public static void LoginSuccess()
        {
            Console.WriteLine("Login successful!");
        }
        public static void LoginFailed()
        {
            Console.WriteLine("Oops, something went wrong!");
        }

        public static void LogoutUser()
        {
            Console.WriteLine("Have a nice day!");
        }
    }
}
