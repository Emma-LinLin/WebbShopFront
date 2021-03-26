using System;
using System.Collections.Generic;
using System.Text;
using WebbShopFrontInlamning.Views;
using WebbShopInlamningsUppgift;

namespace WebbShopFrontInlamning.Controllers
{
    class Logout
    {
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
