using System;
using System.Collections.Generic;
using System.Text;

namespace WebbShopFrontInlamning.Views
{
    /// <summary>
    /// Displays login guidelines for user
    /// </summary>
    class AccountViews
    {
        /// <summary>
        /// Displays login page
        /// </summary>
        public static void LoginPage()
        {
            Console.WriteLine("Login page");
            Console.WriteLine();
            Console.WriteLine("Please fill in the following: ");
            Console.WriteLine("1. User name: ");
            Console.WriteLine("2. Password: ");
        }

        /// <summary>
        /// Displays if login was successful
        /// </summary>
        public static void LoginSuccess()
        {
            Console.WriteLine("Login successful!");
        }

        /// <summary>
        /// Displays if login failed
        /// </summary>
        public static void LoginFailed()
        {
            Console.WriteLine("You don't seem to have an account, please register.");
        }

        /// <summary>
        /// Displays goodbye message for user
        /// </summary>
        public static void LogoutUser()
        {
            Console.WriteLine("Have a nice day!");
        }
    }
}
