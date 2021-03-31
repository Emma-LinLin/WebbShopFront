using System;
using System.Collections.Generic;
using System.Text;
using WebbShopFrontInlamning.Views;
using WebbShopInlamningsUppgift;

namespace WebbShopFrontInlamning.Controllers
{
    /// <summary>
    /// Controls the log out functionality
    /// </summary>
    class Logout
    {
        /// <summary>
        /// Runs the logout functionality page
        /// </summary>
        /// <param name="userId"></param>
        public void Run(int userId)
        {
            if(userId == 0)
            {
                return;
            }

            WebbShopAPI api = new WebbShopAPI();
            AccountViews.LogoutUser();
            api.Logout(userId);
        }
    }
}
