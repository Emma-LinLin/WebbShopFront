using System;
using System.Collections.Generic;
using System.Text;

namespace WebbShopFrontInlamning.Views
{
    /// <summary>
    /// Displays view for user
    /// </summary>
    class ManageAccountViews
    {
        /// <summary>
        /// Displays the information needed to register new account
        /// </summary>
        public static void RegisterAccount()
        {
            Console.WriteLine("Register new user");
            Console.WriteLine();
            Console.WriteLine("Please fill in the following");
            Console.WriteLine("1. Choose user name: ");
            Console.WriteLine("2. Choose password: ");
            Console.WriteLine("3. Verify password: ");
        }

        /// <summary>
        /// Displays an message if registration successful
        /// </summary>
        public static void RegisterSuccess()
        {
            Console.WriteLine();
            Console.WriteLine("Sucessfully registered!");
            Console.WriteLine();
        }

        /// <summary>
        /// Displays an message if registration unsuccessful
        /// </summary>
        public static void RegisterFailed()
        {
            Console.WriteLine();
            Console.WriteLine("Oops, something went wrong! Try with another user name");
            Console.WriteLine();
        }

        /// <summary>
        /// Displays information needed to add a new account
        /// </summary>
        public static void AddAccount()
        {
            Console.WriteLine("Register new user");
            Console.WriteLine();
            Console.WriteLine("Please fill in the following");
            Console.WriteLine("1. Choose user name: ");
            Console.WriteLine("2. Choose password: ");
        }
    }
}
