using System;
using System.Collections.Generic;
using System.Text;
using WebbShopFrontInlamning.Views;
using WebbShopInlamningsUppgift;

namespace WebbShopFrontInlamning.Controllers
{
    class User
    {
        public void RegisterAccount()
        {
            ManageAccountViews.RegisterAccount();
            var userName = Console.ReadLine();
            var userPassword = Console.ReadLine();
            var verifyPassword = Console.ReadLine();

            bool result = CheckRegistrationStatus(userName, userPassword, verifyPassword);
            if (result)
            {
                ManageAccountViews.RegisterSuccess();
                return;
            }

            ManageAccountViews.RegisterFailed();
        }
        private bool CheckRegistrationStatus(string userName, string userPassword, string verifyPassword)
        {
            if(userName != "" && userPassword != "" && verifyPassword != "")
            {
                WebbShopAPI api = new WebbShopAPI();
                return api.Register(userName, userPassword, verifyPassword);
            }
            return false;
        }
    }
}
