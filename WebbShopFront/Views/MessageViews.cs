using System;
using System.Collections.Generic;
using System.Text;

namespace WebbShopFrontInlamning.Views
{
    class MessageViews
    {
        public static void DisplayErrorMessage()
        {
            Console.WriteLine("Oops, something went wrong!");
        }

        public static void DisplaySelectMessage()
        {
            Console.WriteLine("Please select one of the above: ");
        }

        public static void DisplayReturnMessage()
        {
            Console.WriteLine("(Press [0] to return to previous page)");
        }

        public static void DisplaySuccessMessage()
        {
            Console.WriteLine("Success!");
        }

        public static void DisplayNonAvailableMessage()
        {
            Console.WriteLine("Option is non available");
        }
    }
}
