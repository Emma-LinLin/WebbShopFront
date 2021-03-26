using System;
using System.Collections.Generic;
using System.Text;
using WebbShopFrontInlamning.Views;
using WebbShopInlamningsUppgift;

namespace WebbShopFrontInlamning.Controllers
{
    class Login
    {
        public int Run()
        {
            AccountViews.LoginPage();
            var userName = Console.ReadLine();
            var userPassword = Console.ReadLine();
            return CheckLoginStatus(userName, userPassword);
        }
        public int CheckLoginStatus(string userName, string userPassword)
        {
            if (userName != "" && userPassword != "")
            {
                WebbShopAPI api = new WebbShopAPI();
                var user = api.Login(userName, userPassword);
                if (user != 0)
                {
                    AccountViews.LoginSuccess();
                    return user;
                }
                else
                {
                    AccountViews.LoginFailed();
                }
            }
            return 0;
        }
    }
}
