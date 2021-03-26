using System;
using System.Collections.Generic;
using System.Text;
using WebbShopFrontInlamning.Helpers;
using WebbShopFrontInlamning.Views;
using WebbShopInlamningsUppgift;

namespace WebbShopFrontInlamning.Controllers
{
    class Admin
    {
        private int userId;
        
        public int Run()
        {
            AdminView.StartPage();
            AccountViews.LoginPage();
            userId = new Login().Run();
            if(userId == 0)
            {
                return 0;
            }

            var result = CheckAdmin(userId);
            if (!result)
            {
                AdminView.VerifyAdminFailed();
                return 0;
            }

            bool keepGoing = true;
            while (keepGoing)
            {
                AdminView.AdminPage();
                var input = InputHelper.ParseInput();

                switch (input)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        keepGoing = false;
                        break;
                    default:
                        break;
                }
            }
            return userId;
        }

        public bool CheckAdmin(int userId)
        {
            WebbShopAPI api = new WebbShopAPI();
            //Checking random adminfunctionality, if the return value is larger than 0 the userId is valid.
            var list = api.ListUsers(userId);
            if(list.Count > 0)
            {
                return true;
            }
            return false; 
        }
    }
}
