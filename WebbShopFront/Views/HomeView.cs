using System;
using System.Collections.Generic;
using System.Text;

namespace WebbShopFrontInlamning.Views
{
    class HomeView
    {
        public static void MainMeny()
        {
            Console.WriteLine("Welcome to the book store!");
            Console.WriteLine();
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            Console.WriteLine("3. Browse books");
            Console.WriteLine("4. Purchase");
            Console.WriteLine("5. Admin");
            Console.WriteLine("6. Logout");
            Console.WriteLine();
        }
    }
}
