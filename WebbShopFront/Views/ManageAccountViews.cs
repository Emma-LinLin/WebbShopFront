using System;
using System.Collections.Generic;
using System.Text;

namespace WebbShopFrontInlamning.Views
{
    class ManageAccountViews
    {
        public static void RegisterAccount()
        {
            Console.WriteLine("Register new user");
            Console.WriteLine();
            Console.WriteLine("Choose user name: ");
            Console.WriteLine("Choose password: ");
            Console.WriteLine("Verify password: ");
        }
        public static void RegisterSuccess()
        {
            Console.WriteLine();
            Console.WriteLine("Sucessfully registered! You can now login");
            Console.WriteLine();
        }
        public static void RegisterFailed()
        {
            Console.WriteLine();
            Console.WriteLine("Oops, something went wrong!");
            Console.WriteLine();
        }
        public static void AddAccount()
        {
            Console.WriteLine("Register new user");
            Console.WriteLine();
            Console.WriteLine("Choose user name: ");
            Console.WriteLine("Choose password: ");
        }
    }
}
