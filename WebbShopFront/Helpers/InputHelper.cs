using System;
using System.Collections.Generic;
using System.Text;

namespace WebbShopFrontInlamning.Helpers
{
    public class InputHelper
    {
        public static int ParseInput()
        {
            int value;
            while (true)
            {
                try
                {
                    value = int.Parse(Console.ReadLine());
                    return value;
                }
                catch (Exception)
                {
                    Console.WriteLine("Only numbers please! Try again");
                }
            }
        }
    }
}
