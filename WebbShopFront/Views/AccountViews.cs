using System;
using System.Collections.Generic;
using System.Text;

namespace WebbShopFrontInlamning.Views
{
    class AccountViews
    {
        public static void LoginPage()
        {
            Console.WriteLine("Log in");
            Console.WriteLine();
            Console.WriteLine("User name: ");
            Console.WriteLine("Password: ");
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
