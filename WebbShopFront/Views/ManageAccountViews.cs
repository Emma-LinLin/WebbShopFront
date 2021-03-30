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
            Console.WriteLine("Please fill in the following");
            Console.WriteLine("1. Choose user name: ");
            Console.WriteLine("2. Choose password: ");
            Console.WriteLine("3. Verify password: ");
        }

        public static void RegisterSuccess()
        {
            Console.WriteLine();
            Console.WriteLine("Sucessfully registered!");
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
            Console.WriteLine("Please fill in the following");
            Console.WriteLine("1. Choose user name: ");
            Console.WriteLine("2. Choose password: ");
        }
    }
}
